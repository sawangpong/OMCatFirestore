using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Firebase;
using Firebase.Storage;
using System.Reactive.Linq;
using Google.Cloud.Firestore;
using Google.Cloud.Storage;
using Google.Cloud.Storage.V1;

namespace OMCatFireStore
{
	public partial class DbManager : Form
	{

		///
		//var firebaseConfig = {
		//		apiKey: "AIzaSyArIv-Ffc6wPWFXgtBYHhbBupVSmS_Iww4",
		//		authDomain: "omcat20.firebaseapp.com",
		//		databaseURL: "https://omcat20.firebaseio.com",
		//		projectId: "omcat20",
		//		storageBucket: "omcat20.appspot.com",
		//		messagingSenderId: "1054757463439",
		//		appId: "1:1054757463439:web:6ddb666f1db1f7c40417fa"
		//	  };
		//			// Initialize Firebase
		//firebase.initializeApp(firebaseConfig);


		#region Class field
		private FirestoreDb db;
		private string _document = "";
		private ActionMode _mode = ActionMode.None;
		private ProductRecord p = new ProductRecord();

		private string fileNameForUpload = "";

		#endregion

		#region class helper

		//private void initDB()
		//{

		//	// Instantiates a client.
		//	using (StorageClient storageClient = StorageClient.Create())
		//	{
		//		// The name for the new bucket.
		//		string bucketName = projectId + "-test-bucket";
		//		try
		//		{
		//			// Creates the new bucket.
		//			//storageClient.CreateBucket(projectId, bucketName);
		//			//txtDetail.Text = $"Storage Client was created - {storageClient.ToString()}";
		//		}
		//		catch (Google.GoogleApiException e)
		//		when (e.Error.Code == 409)
		//		{
		//			// The bucket already exists.  That's fine.
		//			txtDetail.Text =  e.Error.Message;
		//		}
		//	}
		//}

		private void UpdateUI()
		{
			btnSave.Enabled = !String.IsNullOrEmpty(txtName.Text);
		}

		private async void FirebaseSave()
		{
			//MessageBox.Show(db.ToString());
			// Create a document with a ramdom ID in the "Product" collection
			// A DocumentReference doen't contain the data -it's just a path
			// let fetch the current document
			//DocumentSnapshot snapshot = await document.GetSnapshotAsync();
			//txtName.Text = snapshot.GetValue<string>("Name");
			//txtDetail.Text = snapshot.GetValue<string>("Detail");
			//txtPath.Text = snapshot.GetValue<string>("PathImage");
			//pictureBox1.ImageLocation = txtPath.Text;

			/*
			 new
				{
					Name = txtName.Text.ToUpper().Trim(),
					Detail = txtDetail.Text.Trim(),
					PathImage = txtPath.Text.Trim(),
					Image = FSBHelper.ConvertImageToBase64(ImageBox.Image)
				}

				ProductRecord p = new ProductRecord
				{
					Id = _document,
					Name = txtName.Text.Trim(),
					Detail = txtDetail.Text.Trim(),
					PathImage = txtPath.Text.Trim(),
					Image = FSBHelper.ConvertImageToBase64(ImageBox.Image)
				};
			 */

			// test upload file
			//UploadImageToFireStore();


			CollectionReference collectionReference = db.Collection("Product");

			if (_mode == ActionMode.Add)
			{
				DocumentReference document = await collectionReference.AddAsync(p);
			}
			else if (_mode == ActionMode.Edit)
			{
				Dictionary<FieldPath, object> updates = new Dictionary<FieldPath, object>
				{
					{new FieldPath("Name"), p.Name },
					{new FieldPath("Detail"),p.Detail },
					{new FieldPath("PathImage"),p.PathImage },
					{new FieldPath("Image"),p.Image }
				};

				await collectionReference.Document(_document).UpdateAsync(updates);
				//DocumentReference docRef = 
				//db.Collection("Product").Document(_document);
				//await docRef.SetAsync(p);
			}
		}

		private async void GetDocument(string id)
		{
			StringBuilder s = new StringBuilder();
			DocumentReference docRef = db.Collection("Product").Document(id);
			DocumentSnapshot snapshot = await docRef.GetSnapshotAsync();

			if (snapshot.Exists)
			{
				p = snapshot.ConvertTo<ProductRecord>();
				lbDocId.Text = p.Id;
				txtName.Text = p.Name;
				txtDetail.Text = p.Detail;
				txtPath.Text = p.PathImage;
				ImageBox.Image = String.IsNullOrEmpty(p.Image) ? null : FSBHelper.ConvertBase64ToImage(p.Image);
			}
			else
			{
				MessageBox.Show("Document not exits!");
			}
			UpdateUI();
		}

		private async void UploadImageToFireStore()
		{
			var stream = File.Open(@fileNameForUpload, FileMode.Open);

			var task = new FirebaseStorage(FSBHelper.StorageBucketName).Child("Product").Child("random").Child(fileNameForUpload).PutAsync(stream);

			task.Progress.ProgressChanged += (s, e) => lbProgress.Text = $"Progress : {e.Percentage} %";

			var downloadUrl = await task;

			MessageBox.Show(downloadUrl.ToString());
		}


		#endregion


		public DbManager(string document = "")
		{
			InitializeComponent();
			db = FSBHelper.db;
			_document = document;

			if (!String.IsNullOrEmpty(_document))
			{
				_mode = ActionMode.Edit;
				GetDocument(_document);
			}
			else
			{
				_mode = ActionMode.Add;
				txtName.Text = "";
				txtDetail.Text = "";
				txtPath.Text = "";
				ImageBox.Image = null;
			}

			lbMode.Text = _mode.ToString();
			lbDocId.Text = _document;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			//FirebaseHelper();
			//txtName.Text = $"FirestoreChangeListener Db = {db.Collection("Product").Id.ToString()}";
			//initDB();

			UpdateUI();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			p.Id = lbDocId.Text.Trim();
			p.Name = txtName.Text.Trim();
			p.PathImage = txtPath.Text.Trim();
			p.Detail = txtDetail.Text.Trim();
			p.Image = ImageBox.Image == null ? "" : FSBHelper.ConvertImageToBase64(ImageBox.Image);

			UploadImageToFireStore();

			//FirebaseSave();
		}

		private void txtName_TextChanged(object sender, EventArgs e)
		{
			UpdateUI();
		}

		private void txtPath_TextChanged(object sender, EventArgs e)
		{
			try
			{
				pic.ImageLocation = txtPath.Text.Trim();
			}
			catch
			{
				pic.Image = null;
			}
		}

		private void btnBrowse_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Title = "Select Image";
			ofd.Filter = "Image files (*.jpg)| *.jpg|(*.png)| *.png|All files (*.*)| *.*";
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				fileNameForUpload = ofd.FileName;
				Image img = new Bitmap(ofd.FileName);
				ImageBox.Image = img; //img.GetThumbnailImage(350, 200, null, new IntPtr());
			}
		}
	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Google.Cloud.Storage.V1;

namespace OMCatFireStore
{
	public partial class Storage : Form
	{

		#region Class field
		//Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS",@"D:\CURRENT_PROJECT\VS2019\OMCatFireStore\OMCatFireStore\OMCat20-d5f2be34173e.json");



		#endregion

		#region Helper

		private void ListObject(string bucketName, string prefix, string delimeter)
		{
			StringBuilder s = new StringBuilder();

			List<StorageModel> storageModels = new List<StorageModel>();

			// instantiates a client
			var storage = StorageClient.Create();

			var option = new ListObjectsOptions() { Delimiter = delimeter };
			foreach (var storageObject in storage.ListObjects(bucketName, prefix, option))
			{
				//PictureBox pictureBox = new PictureBox();
				//pictureBox.Size = new Size(150, 200);
				//pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
				//pictureBox.ImageLocation = "";

				//s.AppendLine($"{storageObject.Name}: {storageObject.MediaLink }");
				//txt.Invoke(new Action(() => {
				//	txt.AppendText($"{storageObject.Id}\t\t: {storageObject.Bucket}\t\t : {storageObject.Name} \r\n");
				//}));

				var bucket = storage.GetBucket(bucketName);

				storageModels.Add(new StorageModel()
				{
					Id = storageObject.Id,
					Bucket = storageObject.Bucket,
					Name = storageObject.Name,
					Link = storageObject.SelfLink,
					MediaLink = bucket.Website.ToString(),
					Kms = storageObject.KmsKeyName
				});
			}

			dgv.DataSource = storageModels;
			/*
			 * https://firebasestorage.googleapis.com/v0/b/omcat20.appspot.com/o/Product%2FBU440H.png?alt=media&token=b90e0f36-90b0-4906-8a11-8ad46fc1a1b8
			 * 
			 * gs://omcat20.appspot.com/Product/BU440H.png
			 * 
			 * https://firebasestorage.googleapis.com/v0/b/omcat20.appspot.com/o/Product%2FBU440H.png?alt=media&token=b90e0f36-90b0-4906-8a11-8ad46fc1a1b8
			 */

			//MessageBox.Show(s.ToString());
		}

		#endregion



		public Storage()
		{
			InitializeComponent();
		}

		private void Storage_Load(object sender, EventArgs e)
		{
		}

		private void btnReadStorage_Click(object sender, EventArgs e)
		{
			ListObject(FSBHelper.StorageBucketName, "", "");
		}
	}

	public class StorageModel
	{
		public string Id { get; set; }
		public string Bucket { get; set; }
		public string Name { get; set; }
		public string Link { get; set; }
		public string MediaLink { get; set; }
		public string Kms { get; set; }

	}
}

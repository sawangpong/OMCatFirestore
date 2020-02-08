using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Google.Cloud.Firestore;
using Google.Cloud.Storage;
using Google.Cloud.Storage.V1;

namespace OMCatFireStore
{
	public partial class ProductList : Form
	{
		#region MyRegion
		private FirestoreDb db = FSBHelper.db;
		private string _selectedDocumentId = "";

		#endregion

		#region Class helper
		private async void GetFirebaseData()
		{
			CollectionReference collectionReference = db.Collection("Product");
			QuerySnapshot snapshots = await collectionReference.OrderBy("Name").GetSnapshotAsync();

			//List<DocumentSnapshot> documents = snapshots.ToList();
			List<ProductRecord> products = new List<ProductRecord>();

			foreach (DocumentSnapshot document in snapshots.ToList())
			{
				ProductRecord p = new ProductRecord()
				{
					Id = document.Id,
					Name = document.GetValue<String>("Name"),
					Detail = document.GetValue<String>("Detail"),
					PathImage = document.GetValue<String>("PathImage"),
					Image = document.GetValue<String>("Image")
				};

				products.Add(p);

			}
			

			// mapping list to datagridview datasource
			dgv.DataSource = products;
	
			// decorated columns
			//dgv.Columns["PathImage"].Visible = false;

			UpdateUI();

		}

		private void UpdateUI()
		{
			btnEdit.Enabled = !String.IsNullOrEmpty(_selectedDocumentId);
			btnDelete.Enabled = btnEdit.Enabled;
		}

		private void AddEditData(string doc)
		{
			using (DbManager dbManager = new DbManager(doc))
			{
				dbManager.StartPosition = FormStartPosition.CenterScreen;
				dbManager.ShowDialog(this);
			}
		}

		private async void DeleteData(string doc)
		{
			try
			{
				DocumentReference docRef = db.Collection("Product").Document(doc);
				await docRef.DeleteAsync();
			}
			catch
			{
				MessageBox.Show("Can't delete selected data, try again..", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		#endregion


		public ProductList()
		{
			InitializeComponent();
			_selectedDocumentId = "";
		}

		private void btnLoadData_Click(object sender, EventArgs e)
		{
			GetFirebaseData();
		}

		private void dgv_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			//pictureBox1.ImageLocation = dgv["PathImage", e.RowIndex].Value.ToString();

			string _stringImage = dgv["Image", e.RowIndex].Value.ToString();
			if (String.IsNullOrEmpty(_stringImage))
			{
				pic.Image = null;
			}
			else
			{
				pic.Image = FSBHelper.ConvertBase64ToImage(_stringImage);
				//pic.BackColor = Color.Transparent;
			}
			_selectedDocumentId = dgv["Id", e.RowIndex].Value.ToString();

			UpdateUI();
		}

		private void btnAddData_Click(object sender, EventArgs e)
		{
			_selectedDocumentId = "";
			AddEditData(_selectedDocumentId);
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			AddEditData(_selectedDocumentId);
		}

		private void ProductList_Load(object sender, EventArgs e)
		{
			UpdateUI();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if(MessageBox.Show("Do you want to delete selected data from FireStore?","Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				DeleteData(_selectedDocumentId);
			}
		}
	}
	

	

}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OMCatFireStore
{
	public partial class OMCat20FireStore : Form
	{
		public OMCat20FireStore()
		{
			InitializeComponent();
		}

		private void mnuExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void mnuListData_Click(object sender, EventArgs e)
		{
			ProductList pl = new ProductList();
			pl.MdiParent = this;
			pl.StartPosition = FormStartPosition.CenterScreen;
			pl.WindowState = FormWindowState.Maximized;
			pl.Show();
		}

		private void OMCat20FireStore_Load(object sender, EventArgs e)
		{

		}

		private void mnuStroage_Click(object sender, EventArgs e)
		{
			Storage storage = new Storage();
			storage.MdiParent = this;
			storage.StartPosition = FormStartPosition.CenterScreen;
			storage.WindowState = FormWindowState.Normal;
			storage.Show();
		}
	}
}

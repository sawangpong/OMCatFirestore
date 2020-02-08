namespace OMCatFireStore
{
	partial class DbManager
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.pnlHeader = new System.Windows.Forms.Panel();
			this.lbMode = new System.Windows.Forms.Label();
			this.lbTitle = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.txtDetail = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.txtPath = new System.Windows.Forms.TextBox();
			this.panel5 = new System.Windows.Forms.Panel();
			this.pic = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.lbDocId = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel8 = new System.Windows.Forms.Panel();
			this.btnClearImage = new System.Windows.Forms.Button();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.ImageBox = new System.Windows.Forms.PictureBox();
			this.panel7 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.lbProgress = new System.Windows.Forms.Label();
			this.pnlHeader.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
			this.panel4.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel8.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ImageBox)).BeginInit();
			this.panel7.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlHeader
			// 
			this.pnlHeader.BackColor = System.Drawing.SystemColors.ControlDark;
			this.pnlHeader.Controls.Add(this.lbMode);
			this.pnlHeader.Controls.Add(this.lbTitle);
			this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlHeader.Location = new System.Drawing.Point(0, 0);
			this.pnlHeader.Name = "pnlHeader";
			this.pnlHeader.Padding = new System.Windows.Forms.Padding(4);
			this.pnlHeader.Size = new System.Drawing.Size(853, 55);
			this.pnlHeader.TabIndex = 7;
			// 
			// lbMode
			// 
			this.lbMode.Dock = System.Windows.Forms.DockStyle.Left;
			this.lbMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.lbMode.ForeColor = System.Drawing.Color.Yellow;
			this.lbMode.Location = new System.Drawing.Point(4, 4);
			this.lbMode.Name = "lbMode";
			this.lbMode.Size = new System.Drawing.Size(145, 47);
			this.lbMode.TabIndex = 1;
			this.lbMode.Text = "Mode";
			this.lbMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbTitle
			// 
			this.lbTitle.Dock = System.Windows.Forms.DockStyle.Right;
			this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.lbTitle.ForeColor = System.Drawing.Color.White;
			this.lbTitle.Location = new System.Drawing.Point(421, 4);
			this.lbTitle.Name = "lbTitle";
			this.lbTitle.Size = new System.Drawing.Size(428, 47);
			this.lbTitle.TabIndex = 0;
			this.lbTitle.Text = "Add data to FireStore Database";
			this.lbTitle.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.txtName);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 55);
			this.panel1.Name = "panel1";
			this.panel1.Padding = new System.Windows.Forms.Padding(35, 2, 20, 2);
			this.panel1.Size = new System.Drawing.Size(853, 28);
			this.panel1.TabIndex = 8;
			// 
			// txtName
			// 
			this.txtName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtName.Location = new System.Drawing.Point(163, 2);
			this.txtName.Margin = new System.Windows.Forms.Padding(4);
			this.txtName.MaxLength = 50;
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(670, 22);
			this.txtName.TabIndex = 5;
			this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Left;
			this.label1.Location = new System.Drawing.Point(35, 2);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(128, 24);
			this.label1.TabIndex = 4;
			this.label1.Text = "Name :";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.txtDetail);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 83);
			this.panel2.Name = "panel2";
			this.panel2.Padding = new System.Windows.Forms.Padding(35, 2, 20, 2);
			this.panel2.Size = new System.Drawing.Size(853, 28);
			this.panel2.TabIndex = 9;
			// 
			// txtDetail
			// 
			this.txtDetail.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtDetail.Location = new System.Drawing.Point(163, 2);
			this.txtDetail.Margin = new System.Windows.Forms.Padding(4);
			this.txtDetail.MaxLength = 150;
			this.txtDetail.Name = "txtDetail";
			this.txtDetail.Size = new System.Drawing.Size(670, 22);
			this.txtDetail.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.Dock = System.Windows.Forms.DockStyle.Left;
			this.label4.Location = new System.Drawing.Point(35, 2);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(128, 24);
			this.label4.TabIndex = 4;
			this.label4.Text = "Detail:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.txtPath);
			this.panel3.Controls.Add(this.panel5);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 111);
			this.panel3.Name = "panel3";
			this.panel3.Padding = new System.Windows.Forms.Padding(35, 2, 20, 2);
			this.panel3.Size = new System.Drawing.Size(853, 164);
			this.panel3.TabIndex = 10;
			// 
			// txtPath
			// 
			this.txtPath.Dock = System.Windows.Forms.DockStyle.Top;
			this.txtPath.Location = new System.Drawing.Point(163, 2);
			this.txtPath.Margin = new System.Windows.Forms.Padding(4);
			this.txtPath.Multiline = true;
			this.txtPath.Name = "txtPath";
			this.txtPath.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtPath.Size = new System.Drawing.Size(670, 83);
			this.txtPath.TabIndex = 13;
			this.txtPath.TextChanged += new System.EventHandler(this.txtPath_TextChanged);
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.pic);
			this.panel5.Controls.Add(this.label2);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel5.Location = new System.Drawing.Point(35, 2);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(128, 160);
			this.panel5.TabIndex = 12;
			// 
			// pic
			// 
			this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pic.Location = new System.Drawing.Point(0, 26);
			this.pic.Name = "pic";
			this.pic.Padding = new System.Windows.Forms.Padding(4);
			this.pic.Size = new System.Drawing.Size(128, 134);
			this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic.TabIndex = 6;
			this.pic.TabStop = false;
			// 
			// label2
			// 
			this.label2.Dock = System.Windows.Forms.DockStyle.Top;
			this.label2.Location = new System.Drawing.Point(0, 0);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(128, 26);
			this.label2.TabIndex = 5;
			this.label2.Text = "Image location:";
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.lbDocId);
			this.panel4.Controls.Add(this.btnSave);
			this.panel4.Controls.Add(this.btnCancel);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel4.Location = new System.Drawing.Point(0, 500);
			this.panel4.Name = "panel4";
			this.panel4.Padding = new System.Windows.Forms.Padding(10);
			this.panel4.Size = new System.Drawing.Size(853, 55);
			this.panel4.TabIndex = 11;
			// 
			// lbDocId
			// 
			this.lbDocId.Dock = System.Windows.Forms.DockStyle.Left;
			this.lbDocId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.lbDocId.ForeColor = System.Drawing.Color.Black;
			this.lbDocId.Location = new System.Drawing.Point(10, 10);
			this.lbDocId.Name = "lbDocId";
			this.lbDocId.Size = new System.Drawing.Size(399, 35);
			this.lbDocId.TabIndex = 2;
			this.lbDocId.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// btnSave
			// 
			this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnSave.Location = new System.Drawing.Point(617, 10);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(113, 35);
			this.btnSave.TabIndex = 1;
			this.btnSave.Text = "&Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnCancel.Location = new System.Drawing.Point(730, 10);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(113, 35);
			this.btnCancel.TabIndex = 0;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// panel6
			// 
			this.panel6.Controls.Add(this.lbProgress);
			this.panel6.Controls.Add(this.panel8);
			this.panel6.Controls.Add(this.ImageBox);
			this.panel6.Controls.Add(this.panel7);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel6.Location = new System.Drawing.Point(0, 275);
			this.panel6.Name = "panel6";
			this.panel6.Padding = new System.Windows.Forms.Padding(35, 2, 20, 2);
			this.panel6.Size = new System.Drawing.Size(853, 197);
			this.panel6.TabIndex = 12;
			// 
			// panel8
			// 
			this.panel8.Controls.Add(this.btnClearImage);
			this.panel8.Controls.Add(this.btnBrowse);
			this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel8.Location = new System.Drawing.Point(352, 2);
			this.panel8.Name = "panel8";
			this.panel8.Padding = new System.Windows.Forms.Padding(5);
			this.panel8.Size = new System.Drawing.Size(481, 43);
			this.panel8.TabIndex = 14;
			// 
			// btnClearImage
			// 
			this.btnClearImage.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnClearImage.Location = new System.Drawing.Point(354, 5);
			this.btnClearImage.Name = "btnClearImage";
			this.btnClearImage.Size = new System.Drawing.Size(122, 33);
			this.btnClearImage.TabIndex = 1;
			this.btnClearImage.Text = "Clear Image";
			this.btnClearImage.UseVisualStyleBackColor = true;
			// 
			// btnBrowse
			// 
			this.btnBrowse.Dock = System.Windows.Forms.DockStyle.Left;
			this.btnBrowse.Location = new System.Drawing.Point(5, 5);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(122, 33);
			this.btnBrowse.TabIndex = 0;
			this.btnBrowse.Text = "Browse Image";
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// ImageBox
			// 
			this.ImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ImageBox.Dock = System.Windows.Forms.DockStyle.Left;
			this.ImageBox.Location = new System.Drawing.Point(163, 2);
			this.ImageBox.Name = "ImageBox";
			this.ImageBox.Padding = new System.Windows.Forms.Padding(4);
			this.ImageBox.Size = new System.Drawing.Size(189, 193);
			this.ImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.ImageBox.TabIndex = 13;
			this.ImageBox.TabStop = false;
			// 
			// panel7
			// 
			this.panel7.Controls.Add(this.label3);
			this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel7.Location = new System.Drawing.Point(35, 2);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(128, 193);
			this.panel7.TabIndex = 12;
			// 
			// label3
			// 
			this.label3.Dock = System.Windows.Forms.DockStyle.Top;
			this.label3.Location = new System.Drawing.Point(0, 0);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(128, 26);
			this.label3.TabIndex = 5;
			this.label3.Text = "Image:";
			// 
			// lbProgress
			// 
			this.lbProgress.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lbProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.lbProgress.ForeColor = System.Drawing.Color.Black;
			this.lbProgress.Location = new System.Drawing.Point(352, 160);
			this.lbProgress.Name = "lbProgress";
			this.lbProgress.Size = new System.Drawing.Size(481, 35);
			this.lbProgress.TabIndex = 15;
			this.lbProgress.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// DbManager
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(853, 555);
			this.Controls.Add(this.panel6);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pnlHeader);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "DbManager";
			this.Text = "Database Manager";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.pnlHeader.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
			this.panel4.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ImageBox)).EndInit();
			this.panel7.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel pnlHeader;
		private System.Windows.Forms.Label lbTitle;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox txtDetail;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.TextBox txtPath;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.PictureBox pic;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lbMode;
		private System.Windows.Forms.Label lbDocId;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Button btnClearImage;
		private System.Windows.Forms.Button btnBrowse;
		private System.Windows.Forms.PictureBox ImageBox;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lbProgress;
	}
}


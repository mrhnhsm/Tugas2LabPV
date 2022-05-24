/*
 * Created by SharpDevelop.
 * User: asus
 * Date: 5/22/2022
 * Time: 9:34 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Tugas2LabPV
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.TextBox input_id;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button buttonsaveupload;
		private System.Windows.Forms.Button buttonopendownload;
		private System.Windows.Forms.Button buttonsavedownload;
		private System.Windows.Forms.Button buttonopenuploadd;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.input_id = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.buttonsaveupload = new System.Windows.Forms.Button();
			this.buttonopendownload = new System.Windows.Forms.Button();
			this.buttonsavedownload = new System.Windows.Forms.Button();
			this.buttonopenuploadd = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Aqua;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Location = new System.Drawing.Point(14, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(308, 40);
			this.label1.TabIndex = 0;
			this.label1.Text = "Test Upload File";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Aqua;
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label2.Location = new System.Drawing.Point(353, 29);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(308, 40);
			this.label2.TabIndex = 1;
			this.label2.Text = "Test Download File";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Teal;
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label3.Location = new System.Drawing.Point(14, 436);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(648, 62);
			this.label3.TabIndex = 2;
			this.label3.Text = "Data dari Database \"filetugaspv\" Table \"tabelfile\"";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.IndianRed;
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Location = new System.Drawing.Point(14, 64);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(308, 288);
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.IndianRed;
			this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox2.Location = new System.Drawing.Point(353, 64);
			this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(308, 288);
			this.pictureBox2.TabIndex = 5;
			this.pictureBox2.TabStop = false;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// input_id
			// 
			this.input_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.input_id.Location = new System.Drawing.Point(549, 325);
			this.input_id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.input_id.Name = "input_id";
			this.input_id.Size = new System.Drawing.Size(112, 26);
			this.input_id.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.RosyBrown;
			this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label4.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.MistyRose;
			this.label4.Location = new System.Drawing.Point(353, 325);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(199, 27);
			this.label4.TabIndex = 3;
			this.label4.Text = "Input ID Gambar ";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.Color.LightCoral;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(14, 491);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(648, 246);
			this.dataGridView1.TabIndex = 7;
			// 
			// buttonsaveupload
			// 
			this.buttonsaveupload.BackColor = System.Drawing.Color.SlateBlue;
			this.buttonsaveupload.Location = new System.Drawing.Point(183, 371);
			this.buttonsaveupload.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.buttonsaveupload.Name = "buttonsaveupload";
			this.buttonsaveupload.Size = new System.Drawing.Size(138, 45);
			this.buttonsaveupload.TabIndex = 9;
			this.buttonsaveupload.Text = "Save File";
			this.buttonsaveupload.UseVisualStyleBackColor = false;
			this.buttonsaveupload.Click += new System.EventHandler(this.ButtonsaveuploadClick);
			// 
			// buttonopendownload
			// 
			this.buttonopendownload.BackColor = System.Drawing.Color.SlateBlue;
			this.buttonopendownload.Location = new System.Drawing.Point(353, 371);
			this.buttonopendownload.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.buttonopendownload.Name = "buttonopendownload";
			this.buttonopendownload.Size = new System.Drawing.Size(138, 45);
			this.buttonopendownload.TabIndex = 10;
			this.buttonopendownload.Text = "Open File";
			this.buttonopendownload.UseVisualStyleBackColor = false;
			this.buttonopendownload.Click += new System.EventHandler(this.ButtonopendownloadClick);
			// 
			// buttonsavedownload
			// 
			this.buttonsavedownload.BackColor = System.Drawing.Color.SlateBlue;
			this.buttonsavedownload.Location = new System.Drawing.Point(523, 371);
			this.buttonsavedownload.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.buttonsavedownload.Name = "buttonsavedownload";
			this.buttonsavedownload.Size = new System.Drawing.Size(138, 45);
			this.buttonsavedownload.TabIndex = 11;
			this.buttonsavedownload.Text = "Save File";
			this.buttonsavedownload.UseVisualStyleBackColor = false;
			this.buttonsavedownload.Click += new System.EventHandler(this.ButtonsavedownloadClick);
			// 
			// buttonopenuploadd
			// 
			this.buttonopenuploadd.BackColor = System.Drawing.Color.SlateBlue;
			this.buttonopenuploadd.Location = new System.Drawing.Point(14, 371);
			this.buttonopenuploadd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.buttonopenuploadd.Name = "buttonopenuploadd";
			this.buttonopenuploadd.Size = new System.Drawing.Size(138, 45);
			this.buttonopenuploadd.TabIndex = 12;
			this.buttonopenuploadd.Text = "Open File";
			this.buttonopenuploadd.UseVisualStyleBackColor = false;
			this.buttonopenuploadd.Click += new System.EventHandler(this.ButtonopenuploaddClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Coral;
			this.ClientSize = new System.Drawing.Size(675, 764);
			this.Controls.Add(this.buttonopenuploadd);
			this.Controls.Add(this.buttonsavedownload);
			this.Controls.Add(this.buttonopendownload);
			this.Controls.Add(this.buttonsaveupload);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.input_id);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "MainForm";
			this.Text = "Tugas2LabPV";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}

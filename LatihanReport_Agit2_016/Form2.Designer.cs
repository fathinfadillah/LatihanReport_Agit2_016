namespace LatihanReport_Agit2_016
{
	partial class Form2
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtFilename = new System.Windows.Forms.TextBox();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.cbSheet = new System.Windows.Forms.ComboBox();
			this.myPracticeDataSet1 = new LatihanReport_Agit2_016.MyPracticeDataSet();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.myPracticeDataSet1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(26, 56);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(748, 259);
			this.dataGridView1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(47, 339);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Filename :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(47, 378);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Sheet";
			// 
			// txtFilename
			// 
			this.txtFilename.Location = new System.Drawing.Point(135, 336);
			this.txtFilename.Name = "txtFilename";
			this.txtFilename.ReadOnly = true;
			this.txtFilename.Size = new System.Drawing.Size(523, 20);
			this.txtFilename.TabIndex = 3;
			// 
			// btnBrowse
			// 
			this.btnBrowse.Location = new System.Drawing.Point(688, 334);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(75, 23);
			this.btnBrowse.TabIndex = 5;
			this.btnBrowse.Text = "...";
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// cbSheet
			// 
			this.cbSheet.FormattingEnabled = true;
			this.cbSheet.Location = new System.Drawing.Point(135, 375);
			this.cbSheet.Name = "cbSheet";
			this.cbSheet.Size = new System.Drawing.Size(317, 21);
			this.cbSheet.TabIndex = 6;
			this.cbSheet.SelectedIndexChanged += new System.EventHandler(this.cbSheet_SelectedIndexChanged);
			// 
			// myPracticeDataSet1
			// 
			this.myPracticeDataSet1.DataSetName = "MyPracticeDataSet";
			this.myPracticeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.cbSheet);
			this.Controls.Add(this.btnBrowse);
			this.Controls.Add(this.txtFilename);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView1);
			this.MinimizeBox = false;
			this.Name = "Form2";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Read Excel";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.myPracticeDataSet1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtFilename;
		private System.Windows.Forms.Button btnBrowse;
		private System.Windows.Forms.ComboBox cbSheet;
		private MyPracticeDataSet myPracticeDataSet1;
	}
}
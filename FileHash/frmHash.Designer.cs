namespace FileHash
{
	partial class frmHash
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
			this.btnClose = new System.Windows.Forms.Button();
			this.btnHash = new System.Windows.Forms.Button();
			this.cbMD5 = new System.Windows.Forms.CheckBox();
			this.tbFile = new System.Windows.Forms.TextBox();
			this.lblFile = new System.Windows.Forms.Label();
			this.tbMD5 = new FileHash.BorderedTextBox();
			this.tbSHA1 = new FileHash.BorderedTextBox();
			this.cbSHA1 = new System.Windows.Forms.CheckBox();
			this.tbSHA256 = new FileHash.BorderedTextBox();
			this.chSHA256 = new System.Windows.Forms.CheckBox();
			this.tbSHA384 = new FileHash.BorderedTextBox();
			this.cbSHA384 = new System.Windows.Forms.CheckBox();
			this.tbSHA512 = new FileHash.BorderedTextBox();
			this.cbSHA512 = new System.Windows.Forms.CheckBox();
			this.tbBASE64 = new FileHash.BorderedTextBox();
			this.cbBASE64 = new System.Windows.Forms.CheckBox();
			this.btnFindFile = new System.Windows.Forms.Button();
			this.tbValidate = new System.Windows.Forms.TextBox();
			this.btnValidate = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(450, 322);
			this.btnClose.Margin = new System.Windows.Forms.Padding(2);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(60, 25);
			this.btnClose.TabIndex = 0;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
			// 
			// btnHash
			// 
			this.btnHash.Location = new System.Drawing.Point(450, 32);
			this.btnHash.Margin = new System.Windows.Forms.Padding(2);
			this.btnHash.Name = "btnHash";
			this.btnHash.Size = new System.Drawing.Size(60, 25);
			this.btnHash.TabIndex = 4;
			this.btnHash.Text = "Hash";
			this.btnHash.UseVisualStyleBackColor = true;
			this.btnHash.Click += new System.EventHandler(this.BtnHash_Click);
			// 
			// cbMD5
			// 
			this.cbMD5.AutoSize = true;
			this.cbMD5.Checked = true;
			this.cbMD5.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbMD5.Location = new System.Drawing.Point(20, 65);
			this.cbMD5.Margin = new System.Windows.Forms.Padding(2);
			this.cbMD5.Name = "cbMD5";
			this.cbMD5.Size = new System.Drawing.Size(49, 17);
			this.cbMD5.TabIndex = 5;
			this.cbMD5.Text = "MD5";
			this.cbMD5.UseVisualStyleBackColor = true;
			// 
			// tbFile
			// 
			this.tbFile.Location = new System.Drawing.Point(89, 32);
			this.tbFile.Margin = new System.Windows.Forms.Padding(2);
			this.tbFile.Name = "tbFile";
			this.tbFile.Size = new System.Drawing.Size(312, 20);
			this.tbFile.TabIndex = 2;
			this.tbFile.Text = "Select a file or drop file into window";
			// 
			// lblFile
			// 
			this.lblFile.AutoSize = true;
			this.lblFile.Location = new System.Drawing.Point(20, 32);
			this.lblFile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblFile.Name = "lblFile";
			this.lblFile.Size = new System.Drawing.Size(23, 13);
			this.lblFile.TabIndex = 1;
			this.lblFile.Text = "File";
			// 
			// tbMD5
			// 
			this.tbMD5.Location = new System.Drawing.Point(89, 65);
			this.tbMD5.Margin = new System.Windows.Forms.Padding(2);
			this.tbMD5.Name = "tbMD5";
			this.tbMD5.ReadOnly = true;
			this.tbMD5.Size = new System.Drawing.Size(312, 20);
			this.tbMD5.TabIndex = 5;
			this.tbMD5.Text = "MD5";
			// 
			// tbSHA1
			// 
			this.tbSHA1.Location = new System.Drawing.Point(89, 97);
			this.tbSHA1.Margin = new System.Windows.Forms.Padding(2);
			this.tbSHA1.Name = "tbSHA1";
			this.tbSHA1.ReadOnly = true;
			this.tbSHA1.Size = new System.Drawing.Size(312, 20);
			this.tbSHA1.TabIndex = 7;
			this.tbSHA1.Text = "SHA1";
			// 
			// cbSHA1
			// 
			this.cbSHA1.AutoSize = true;
			this.cbSHA1.Checked = true;
			this.cbSHA1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbSHA1.Location = new System.Drawing.Point(20, 97);
			this.cbSHA1.Margin = new System.Windows.Forms.Padding(2);
			this.cbSHA1.Name = "cbSHA1";
			this.cbSHA1.Size = new System.Drawing.Size(54, 17);
			this.cbSHA1.TabIndex = 6;
			this.cbSHA1.Text = "SHA1";
			this.cbSHA1.UseVisualStyleBackColor = true;
			// 
			// tbSHA256
			// 
			this.tbSHA256.Location = new System.Drawing.Point(89, 130);
			this.tbSHA256.Margin = new System.Windows.Forms.Padding(2);
			this.tbSHA256.Name = "tbSHA256";
			this.tbSHA256.ReadOnly = true;
			this.tbSHA256.Size = new System.Drawing.Size(312, 20);
			this.tbSHA256.TabIndex = 9;
			this.tbSHA256.Text = "SHA256";
			// 
			// chSHA256
			// 
			this.chSHA256.AutoSize = true;
			this.chSHA256.Checked = true;
			this.chSHA256.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chSHA256.Location = new System.Drawing.Point(20, 130);
			this.chSHA256.Margin = new System.Windows.Forms.Padding(2);
			this.chSHA256.Name = "chSHA256";
			this.chSHA256.Size = new System.Drawing.Size(66, 17);
			this.chSHA256.TabIndex = 8;
			this.chSHA256.Text = "SHA256";
			this.chSHA256.UseVisualStyleBackColor = true;
			// 
			// tbSHA384
			// 
			this.tbSHA384.Location = new System.Drawing.Point(89, 162);
			this.tbSHA384.Margin = new System.Windows.Forms.Padding(2);
			this.tbSHA384.Name = "tbSHA384";
			this.tbSHA384.ReadOnly = true;
			this.tbSHA384.Size = new System.Drawing.Size(312, 20);
			this.tbSHA384.TabIndex = 11;
			this.tbSHA384.Text = "SHA384";
			// 
			// cbSHA384
			// 
			this.cbSHA384.AutoSize = true;
			this.cbSHA384.Checked = true;
			this.cbSHA384.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbSHA384.Location = new System.Drawing.Point(20, 162);
			this.cbSHA384.Margin = new System.Windows.Forms.Padding(2);
			this.cbSHA384.Name = "cbSHA384";
			this.cbSHA384.Size = new System.Drawing.Size(66, 17);
			this.cbSHA384.TabIndex = 10;
			this.cbSHA384.Text = "SHA384";
			this.cbSHA384.UseVisualStyleBackColor = true;
			// 
			// tbSHA512
			// 
			this.tbSHA512.Location = new System.Drawing.Point(89, 195);
			this.tbSHA512.Margin = new System.Windows.Forms.Padding(2);
			this.tbSHA512.Name = "tbSHA512";
			this.tbSHA512.ReadOnly = true;
			this.tbSHA512.Size = new System.Drawing.Size(312, 20);
			this.tbSHA512.TabIndex = 13;
			this.tbSHA512.Text = "SHA512";
			// 
			// cbSHA512
			// 
			this.cbSHA512.AutoSize = true;
			this.cbSHA512.Checked = true;
			this.cbSHA512.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbSHA512.Location = new System.Drawing.Point(20, 195);
			this.cbSHA512.Margin = new System.Windows.Forms.Padding(2);
			this.cbSHA512.Name = "cbSHA512";
			this.cbSHA512.Size = new System.Drawing.Size(66, 17);
			this.cbSHA512.TabIndex = 12;
			this.cbSHA512.Text = "SHA512";
			this.cbSHA512.UseVisualStyleBackColor = true;
			// 
			// tbBASE64
			// 
			this.tbBASE64.Location = new System.Drawing.Point(89, 227);
			this.tbBASE64.Margin = new System.Windows.Forms.Padding(2);
			this.tbBASE64.Name = "tbBASE64";
			this.tbBASE64.ReadOnly = true;
			this.tbBASE64.Size = new System.Drawing.Size(312, 20);
			this.tbBASE64.TabIndex = 15;
			this.tbBASE64.Text = "BASE64";
			// 
			// cbBASE64
			// 
			this.cbBASE64.AutoSize = true;
			this.cbBASE64.Checked = true;
			this.cbBASE64.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbBASE64.Enabled = false;
			this.cbBASE64.Location = new System.Drawing.Point(20, 227);
			this.cbBASE64.Margin = new System.Windows.Forms.Padding(2);
			this.cbBASE64.Name = "cbBASE64";
			this.cbBASE64.Size = new System.Drawing.Size(66, 17);
			this.cbBASE64.TabIndex = 14;
			this.cbBASE64.Text = "BASE64";
			this.cbBASE64.UseVisualStyleBackColor = true;
			// 
			// btnFindFile
			// 
			this.btnFindFile.Location = new System.Drawing.Point(404, 32);
			this.btnFindFile.Margin = new System.Windows.Forms.Padding(2);
			this.btnFindFile.Name = "btnFindFile";
			this.btnFindFile.Size = new System.Drawing.Size(30, 25);
			this.btnFindFile.TabIndex = 3;
			this.btnFindFile.Text = "...";
			this.btnFindFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnFindFile.UseVisualStyleBackColor = true;
			this.btnFindFile.Click += new System.EventHandler(this.BtnFindFile_Click);
			// 
			// tbValidate
			// 
			this.tbValidate.Location = new System.Drawing.Point(89, 263);
			this.tbValidate.Margin = new System.Windows.Forms.Padding(2);
			this.tbValidate.Name = "tbValidate";
			this.tbValidate.Size = new System.Drawing.Size(312, 20);
			this.tbValidate.TabIndex = 17;
			this.tbValidate.Text = "hash to validate";
			// 
			// btnValidate
			// 
			this.btnValidate.Location = new System.Drawing.Point(450, 260);
			this.btnValidate.Margin = new System.Windows.Forms.Padding(2);
			this.btnValidate.Name = "btnValidate";
			this.btnValidate.Size = new System.Drawing.Size(60, 25);
			this.btnValidate.TabIndex = 18;
			this.btnValidate.Text = "Validate";
			this.btnValidate.UseVisualStyleBackColor = true;
			this.btnValidate.Click += new System.EventHandler(this.BtnValidate_Click);
			// 
			// frmHash
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(534, 358);
			this.Controls.Add(this.btnValidate);
			this.Controls.Add(this.tbValidate);
			this.Controls.Add(this.btnFindFile);
			this.Controls.Add(this.tbBASE64);
			this.Controls.Add(this.cbBASE64);
			this.Controls.Add(this.tbSHA512);
			this.Controls.Add(this.cbSHA512);
			this.Controls.Add(this.tbSHA384);
			this.Controls.Add(this.cbSHA384);
			this.Controls.Add(this.tbSHA256);
			this.Controls.Add(this.chSHA256);
			this.Controls.Add(this.tbSHA1);
			this.Controls.Add(this.cbSHA1);
			this.Controls.Add(this.tbMD5);
			this.Controls.Add(this.lblFile);
			this.Controls.Add(this.tbFile);
			this.Controls.Add(this.cbMD5);
			this.Controls.Add(this.btnHash);
			this.Controls.Add(this.btnClose);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "frmHash";
			this.Text = "Calculate File Hash";
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.form_DragDrop);
			this.DragEnter += new System.Windows.Forms.DragEventHandler(this.form_DragEnter);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnHash;
		private System.Windows.Forms.CheckBox cbMD5;
		private System.Windows.Forms.TextBox tbFile;
		private System.Windows.Forms.Label lblFile;
		private BorderedTextBox tbMD5;
		private BorderedTextBox tbSHA1;
		private System.Windows.Forms.CheckBox cbSHA1;
		private BorderedTextBox tbSHA256;
		private System.Windows.Forms.CheckBox chSHA256;
		private BorderedTextBox tbSHA384;
		private System.Windows.Forms.CheckBox cbSHA384;
		private BorderedTextBox tbSHA512;
		private System.Windows.Forms.CheckBox cbSHA512;
		private BorderedTextBox tbBASE64;
		private System.Windows.Forms.CheckBox cbBASE64;
		private System.Windows.Forms.Button btnFindFile;
		private System.Windows.Forms.TextBox tbValidate;
		private System.Windows.Forms.Button btnValidate;
	}
}


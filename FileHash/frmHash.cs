using System;
using System.Drawing;
using System.Windows.Forms;

namespace FileHash
{
	public partial class frmHash : Form
	{
		public frmHash()
		{
			InitializeComponent();
		}

		private void BtnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void BtnFindFile_Click(object sender, EventArgs e)
		{
			var oFD = new OpenFileDialog()
			{
				FileName = "Select a file",
				Filter = "Text files (*.*)|*.*",
				Title = "Select a file"
			};

			if (oFD.ShowDialog() == DialogResult.OK)
			{
				this.tbFile.Text = oFD.FileName;
			}
			oFD.Dispose();

		}

		private void BtnHash_Click(object sender, EventArgs e)
		{
			var hashes = new HashCalculator(this.tbFile.Text);

			tbMD5.Text = hashes.MD5;
			tbSHA1.Text = hashes.SHA1;
			tbSHA256.Text = hashes.SHA256;
			tbSHA384.Text = hashes.SHA384;
			tbSHA512.Text = hashes.SHA512;

		}

		private void form_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				e.Effect = DragDropEffects.Copy;
			}
			else
			{
				e.Effect = DragDropEffects.None;
			}
		}

		private void form_DragDrop(object sender, DragEventArgs e)
		{
			string[] filePaths = (string[])e.Data.GetData(DataFormats.FileDrop, false);
			this.tbFile.Text = filePaths[0];
		}

		private void BtnValidate_Click(object sender, EventArgs e)
		{

			var hashToValidate = tbValidate.Text;

			if (compareHashes(hashToValidate, tbMD5.Text) == true)
			{
				tbMD5.BorderColor = Color.Green;
			}
			else
			{
				tbMD5.BorderColor = Color.Transparent;
			}
			if (compareHashes(hashToValidate, tbSHA1.Text) == true)
			{
				tbSHA1.BorderColor = Color.Green;
			}
			else
			{
				tbSHA1.BorderColor = Color.Transparent;
			}
			if (compareHashes(hashToValidate, tbSHA256.Text) == true)
			{
				tbSHA256.BorderColor = Color.Green;
			}
			else
			{
				tbSHA256.BorderColor = Color.Transparent;
			}
			if (compareHashes(hashToValidate, tbSHA384.Text) == true)
			{
				tbSHA384.BorderColor = Color.Green;
			}
			else
			{
				tbSHA384.BorderColor = Color.Transparent;
			}
			if (compareHashes(hashToValidate, tbSHA512.Text) == true)
			{
				tbSHA512.BorderColor = Color.Green;
			}
			else
			{
				tbSHA512.BorderColor = Color.Transparent;
			}
		}

		private bool compareHashes (string hashToValidate, string hash)
		{
			// Create a StringComparer an compare the hashes.
			StringComparer comparer = StringComparer.OrdinalIgnoreCase;
			if (comparer.Compare(hashToValidate, hash) == 0)
			{
				return true;
			}
			else {
				return false;
			}
		}
	}
}

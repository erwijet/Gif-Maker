//
//Created by Tyler on 6/9/2018.
//
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Gif_Maker
{
	/// <summary>
	/// Description of EditPathDialog.
	/// </summary>
	public partial class EditPathDialogLegacy : Form
	{
		public enum PathType {
			File,
			Directory
		}
		public string Prompt { get; set; }
		public string SelectedPath { get; set; }
		public PathType @pt { get; set; }
		
		public EditPathDialogLegacy(string input)
		{
            InitializeComponent();
			Prompt = input;
			InitializeComponent();
			label1.Text = input;
			DialogResult = DialogResult.Cancel;       
		}
		
		void Btn_saveClick(object sender, EventArgs e)
		{
			SelectedPath = textBox1.Text;
			DialogResult = DialogResult.OK;
			Close(); //Return
		}
		
		void Btn_cancelClick(object sender, EventArgs e)
		{
			SelectedPath = "";
			DialogResult = DialogResult.Cancel;
			Close(); //Return
		}
		
		void Btn_browseClick(object sender, EventArgs e)
		{
			if (pt == PathType.File)
			{
				//File
				var ofd = new OpenFileDialog();
				if (ofd.ShowDialog() == DialogResult.OK) {
					SelectedPath = ofd.FileName;
					textBox1.Text = SelectedPath;
				}
				ofd.Dispose();
			}
			else
			{
				var fbd = new FolderBrowserDialog();
				if (fbd.ShowDialog() == DialogResult.OK) {
					SelectedPath = fbd.SelectedPath;
					textBox1.Text = SelectedPath;
				}
				fbd.Dispose();
			}
		}

        private void EditPathDialog_Load(object sender, EventArgs e)
        {

        }
    }
}

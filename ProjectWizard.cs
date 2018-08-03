//
//Created by Tyler on 6/10/2018.
//
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;

namespace Gif_Maker
{
	public partial class ProjectWizard : Form
	{
        public GifProj project { get; set; }
        public List<irp> irps;

        public int i = 0;
		public ProjectWizard()
		{
			InitializeComponent();
            irps = new List<irp>();
            lv_images.SmallImageList = new ImageList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tb_psave.Text + tb_pname.Text != "")
            {
                if (!File.Exists(tb_psave.Text)) goto Create;
                else
                {
                    if (MessageBox.Show($"The file {tb_psave.Text} already exists.\nWould you like to replace it and continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        goto Create;
                    goto Exit;
                }
            }
            else { MessageBox.Show("Please fill out all of the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop); goto Exit; }

            Create:
            project = new GifProj();
            project.irps = irps;
            project.ValidateIrps();
            project.SavePath = tb_psave.Text;
            project.SaveName = tb_pname.Text;
            project.SaveMe(project.SavePath);
            DialogResult = DialogResult.OK;
            this.Close();
            Exit:;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Multiselect = true;
                ofd.Filter = "images | *.bmp | GIF images | *.gif | JPEG images | *.jpg; *.jpeg; *.jpe; *.jif; *.jfif; *.jfi | PNG images | *.png | TIFF images | *.tiff; *.tif | All files | *.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    //int i = 0;
                    foreach (string path in ofd.FileNames)
                    {
                        try
                        {
                            irp thisRef = new irp();
                            thisRef.SetPath(path);
                            lv_images.SmallImageList.Images.Add(thisRef.GetImage());
                            lv_images.Items.Add(thisRef.fi.Name, i);
                            irps.Add(thisRef);
                            i++;
                        }
                        catch { }
                    }
                }
            }
            //Update Create button
            if (lv_images.Items.Count > 0)
                btn_create.Enabled = true;
            else
                btn_create.Enabled = false;
        }

        private void ProjectWizard_Load(object sender, EventArgs e)
        {
            tb_psave.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\" + tb_pname.Text + ".gproj";
        }

        private void lv_images_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView me = sender as ListView;
            if (me.Items.Count > 0)
                btn_create.Enabled = true;
            else
                btn_create.Enabled = false;
            if (me.SelectedItems.Count == 0)
                btn_del.Enabled = false;
            else
                btn_del.Enabled = true;
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            int indexCount = lv_images.SelectedIndices.Count;
            for (int i = indexCount; i > 0; i--)
            {
                int thisIndex = lv_images.SelectedIndices[i - 1];
                lv_images.Items.RemoveAt(thisIndex);
                irps.RemoveAt(thisIndex);
            }
            /*
            foreach (int index in lv_images.SelectedIndices)
            {
                lv_images.Items.RemoveAt(index);
                irps.RemoveAt(index);
            }
            */
            //Update Create button
            if (lv_images.Items.Count > 0)
                btn_create.Enabled = true;
            else
                btn_create.Enabled = false;
        }
    }
}

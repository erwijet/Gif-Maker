//
//Created by Tyler on 6/9/2018.
//
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media.Imaging;
using System.Runtime.InteropServices;

namespace Gif_Maker
{
    public partial class MainForm : Form
    {
        public GifProj ActiveProject { get; set; }
        public ImagePropertySlave UpdateSlave { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }
        void MainFormLoad(object sender, EventArgs e)
        {
        }

        void DeleteSelectedImage()
        {
            if (ActiveProject.DataValues.SelectedImage != 0) ActiveProject.irps.Remove(ActiveProject.irps[ActiveProject.DataValues.SelectedImage - 1]);
            UpdateImage();
        }

        void Btn_deleteClick(object sender, EventArgs e)
        {
            if (System.Windows.Forms.MessageBox.Show("Are you sure you want to delete this?", "Hang On There", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DeleteSelectedImage();
            }
        }
        void Button1Click(object sender, EventArgs e)
        {

        }
        void Tmsbtn_exitClick(object sender, EventArgs e)
        {
            this.Close();
        }
        void Tmsbtn_editpathsClick(object sender, EventArgs e)
        {
            if (System.Windows.Forms.MessageBox.Show("Are you sure you would like to move the project file?", "But are you sure??", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using(SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "Gif Maker Project File|*.gproj";
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        File.Move(ActiveProject.SavePath, sfd.FileName);
                        ActiveProject.SavePath = sfd.FileName;
                    }
                }
            }
            /*
             * [LEGACY]
            if (epd.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.Move(ActiveProject.SavePath, epd.SelectedPath);
                ActiveProject.SavePath = epd.SelectedPath;
            }
            epd.Dispose();
            */
        }
        void Tsmbtn_newProjClick(object sender, EventArgs e)
        {
            ProjectWizard frm = new ProjectWizard();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                btn_delete.Enabled = true;
                btn_add.Enabled = true;
                ActiveProject = frm.project;
                UpdateMenuState(true,
                    tsmbtn_changePath,
                    tsmbtn_save,
                    tsmbtn_saveas,
                    tsmbtn_options,
                    tsmbtn_editprojectpath,
                    tsmbtn_next,
                    tsmbtn_previous,
                    tsmbtn_delimg,
                    tsmbtn_rename);
                Text = $"{ActiveProject.SaveName} - Gif Maker";
                UpdateSlave = new ImagePropertySlave(ActiveProject, pictureBox1);
                UpdateImage();
            }
        }

        void UpdateMenuState(bool enabled, params ToolStripMenuItem[] @items)
        {
            foreach (ToolStripMenuItem item in @items)
            {
                item.Enabled = enabled;
            }
        }

		void Label4Click(object sender, EventArgs e)
		{
	        
		}

        private void openProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Gif Maker Projects | *gproj";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    btn_delete.Enabled = true;
                    btn_add.Enabled = true;
                    GifProj proj = GifProj.FromFile(new System.IO.FileInfo(ofd.FileName));
                    ActiveProject = proj;
                    UpdateMenuState(true,
                    tsmbtn_changePath,
                    tsmbtn_save,
                    tsmbtn_saveas,
                    tsmbtn_options,
                    tsmbtn_editprojectpath,
                    tsmbtn_next,
                    tsmbtn_previous,
                    tsmbtn_delimg,
                    tsmbtn_rename);
                    Text = $"{ActiveProject.SaveName} - Gif Maker";
                    UpdateSlave = new ImagePropertySlave(ActiveProject, pictureBox1);
                    UpdateImage();
                }
            }
        }

        private void tsmbtn_closeProj_Click(object sender, EventArgs e)
        {

        }

        private void tsmbtn_save_Click(object sender, EventArgs e)
        { 
            ActiveProject.SaveMe(ActiveProject.SavePath);
        }

        private void tsmbtn_saveas_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Gif Maker Projects | *.gproj";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ActiveProject.SavePath = sfd.FileName;
                    ActiveProject.SaveMe(ActiveProject.SavePath);
                }
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (ActiveProject.DataValues.SelectedImage < ActiveProject.DataValues.TotalImages)
                ActiveProject.DataValues.SelectedImage++;
            UpdateImage();
        }

        private void tsmbtn_next_Click(object sender, EventArgs e)
        {
            btn_next.PerformClick();
        }

        private void tsmbtn_replaceImg_Click(object sender, EventArgs e)
        {
            btn_back.PerformClick();
        }

        private void tsmbtn_delimg_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.MessageBox.Show("Are you sure you want to delete this?", "Hang On There", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DeleteSelectedImage();
            }
        }

        private void tsmbtn_previous_Click(object sender, EventArgs e)
        {
            btn_back.PerformClick();
        }

        internal void UpdateImage()
        {
            ActiveProject.DataValues.TotalImages = (ActiveProject.irps as List<irp>).Count;
            ActiveProject.ValidateIrps();
            string[] data = new string[5];
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = "";
            }
            try
            {
                UpdateSlave.RunSlave(out data[0],
                    out data[1],
                        out data[2],
                            out data[3],
                                out data[4]);
            }
            catch { }
            l_imageIndex.Text = data[0];
            label4.Text = data[1];
            label6.Text = data[2];
            label3.Text = data[3];
            label2.Text = data[4];
        }

        private void tsmbtn_changePath_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "images|*.bmp|GIF images|*.gif|JPEG images|*.jpg; *.jpeg; *.jpe; *.jif; *.jfif; *.jfi|PNG images|*.png|TIFF images|*.tiff; *.tif|All files|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(ofd.FileName))
                        (ActiveProject.irps as List<irp>)[int.Parse(l_imageIndex.Text.Split(new char[] { '/' })[0]) - 1].SetPath(ofd.FileName);
                }
            }
            UpdateImage();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (ActiveProject.DataValues.SelectedImage > 1)
                ActiveProject.DataValues.SelectedImage
                    -- // Remove One
                    ;
            UpdateImage();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "images|*.bmp|GIF images|*.gif|JPEG images|*.jpg; *.jpeg; *.jpe; *.jif; *.jfif; *.jfi|PNG images|*.png|TIFF images|*.tiff; *.tif|All files|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    int insertIndex = ActiveProject.DataValues.SelectedImage;
                    int currentIndex = 0;
                    bool ADDEDPHOTO = false;
                    List<irp> new_irps = new List<irp>();
                    ActiveProject.irps.Reverse();
                    Stack<irp> old_irps = new Stack<irp>((ActiveProject.irps));
                    while (true) {
                        currentIndex++;
                        if (currentIndex == insertIndex)
                        {
                            irp _irp = new irp();
                            _irp.SetPath(ofd.FileName);
                            new_irps.Add(_irp);
                            ADDEDPHOTO = true;
                            currentIndex++;
                        } else
                        {
                            irp _irp = new irp();
                            _irp.SetPath(old_irps.Pop().PathAsString);
                            new_irps.Add(_irp);
                        }
                        if (old_irps.Count == 0 && ADDEDPHOTO) break;
                    }
                    ActiveProject.irps = new_irps;
                    UpdateImage();
                }
            }
        }

        private void tsmbtn_rename_Click(object sender, EventArgs e)
        {
            using (RenameProject rp = new RenameProject(ActiveProject.SaveName))
            {
                if (rp.ShowDialog() == DialogResult.OK)
                {
                    ActiveProject.SaveName = rp.ProjectName;
                    Text = ActiveProject.SaveName + " - " + "Gif Maker";
                }
            }
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            tsmbtn_newProj.PerformClick();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            openProjectToolStripMenuItem.PerformClick();
        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cmd.exe", "/c start http://github.com/erwijet/Gif-Maker");
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            tsmbtn_save.PerformClick();
        }

        public void ShrinkBitmaps(int x, int y)
        {
            if (!Directory.Exists("toEncode")) Directory.CreateDirectory("toEncode");

            foreach (var file in Directory.EnumerateFiles("toEncode"))
            {
                File.Delete(file);
            }

            foreach (irp thisIrp in ActiveProject.irps)
            {
                Image img = Image.FromFile(thisIrp.PathAsString);
                Bitmap resizedImg = new Bitmap(x, y);

                double ratioX = (double)resizedImg.Width / (double)img.Width;
                double ratioY = (double)resizedImg.Height / (double)img.Height;
                double ratio = ratioX < ratioY ? ratioX : ratioY;

                int newHeight = Convert.ToInt32(img.Height * ratio);
                int newWidth = Convert.ToInt32(img.Width * ratio);

                using (Graphics g = Graphics.FromImage(resizedImg))
                {
                    g.DrawImage(img, 0, 0, newWidth, newHeight);
                }
                resizedImg.Save($@"toEncode\{Directory.GetFiles("toEncode").Length}.gif", System.Drawing.Imaging.ImageFormat.Gif);
                img.Dispose();
                resizedImg.Dispose();
                GC.Collect();
            }
        }

        private void btn_build_Click(object sender, EventArgs e)
        {
            Export export = new Export(ActiveProject);
            export.Show();
            /*
            ShrinkBitmaps(150, 150);
            System.Windows.Media.Imaging.GifBitmapEncoder gEnc = new GifBitmapEncoder();
            foreach (var pic in Directory.GetFiles("toEncode"))
            {
                Bitmap bmpImage = (Bitmap)Image.FromFile(pic);
                //var bmp = bmpImage.GetHbitmap();
                var src = System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(
                    bmpImage.GetHbitmap(),
                    IntPtr.Zero,
                    Int32Rect.Empty,
                    BitmapSizeOptions.FromEmptyOptions());
                gEnc.Frames.Add(BitmapFrame.Create(src));
                //Marshal.FreeHGlobal(bmp);
                //bmp = IntPtr.Zero;
                //System.Runtime.InteropServices.Marshal.FreeHGlobal(bmp); // handle memory leak
            }
            using (FileStream fs = new FileStream(@"C:\users\tyler\desktop\testPic.gif", FileMode.Create))
            {
                gEnc.Save(fs);
            }
            gEnc = null;
            GC.Collect();
            */
        }
    }
}

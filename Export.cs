using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media.Imaging;
using System.Runtime.InteropServices;
using System.IO;

namespace Gif_Maker
{
    public partial class Export : Form
    {
        public GifProj proj { get; set; }
        
        public Export(GifProj project)
        {
            InitializeComponent();
            proj = project;

            backgroundWorker1.WorkerReportsProgress = true;

            clb_include.Items.Clear();
            foreach (irp thisIrp in project.irps)
            {
                clb_include.Items.Add(thisIrp.ToString());
                clb_include.SetItemChecked(clb_include.Items.Count - 1, true); // Check all values by default
            }
            textBox1.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\export.gif";
        }

        private void btn_saveto_browse_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "GIF Image|*.gif";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = sfd.FileName;
                }
            }
        }
        
        private void btn_export_Click(object sender, EventArgs e)
        {
            List<irp> include = new List<irp>();
            foreach (var item in clb_include.CheckedItems)
            {
                irp _irp = new irp();
                _irp.SetPath(item.ToString());
                include.Add(_irp);
            }
            backgroundWorker1.RunWorkerAsync(new object[] { nud_wdith.Value, nud_height.Value, include, textBox1.Text, proj.irps });
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            List<irp> irps = (e.Argument as object[])[2] as List<irp>;
            List<irp> totalIrps = (e.Argument as object[])[4] as List<irp>;
            int width = int.Parse(((e.Argument as object[])[0].ToString()));
            int height = int.Parse(((e.Argument as object[])[1].ToString()));
            StreamWriter sw = new StreamWriter(File.Create((e.Argument as object[])[3] as string + ".glog"));
            sw.WriteLine("GIF MAKER DATA LOG. CREATED LOCAL MACHINE TIME: "  + DateTime.Now.ToLocalTime());
            sw.WriteLine("#### INFO ABOUT EXPORT ####");
            sw.WriteLine("REQUESTED FILE DIMENTIONS: " + width.ToString() + " X " + height.ToString());
            sw.WriteLine("TOTAL IMAGE FILES IN PROJECT: " + totalIrps.Count);
            totalIrps = null;
            sw.WriteLine("INCLUDED IMAGE COUNT: " + irps.Count);
            sw.Flush();
            sw.WriteLine("#### END INFO ABOUT EXPORT ####");
            sw.WriteLine("Begin cleaning folder to store images in...");
            GC.Collect();
            if (!Directory.Exists("toEncode")) Directory.CreateDirectory("toEncode");
            List<string> files = new List<string>(Directory.GetFiles("toEncode"));
            sw.WriteLine("Found " + files.Count + " files needed to be deleted");
            foreach (var file in Directory.EnumerateFiles("toEncode"))
            {
                sw.WriteLine("...Attemping to delete \"" + file + "\"");
                backgroundWorker1.ReportProgress((100 * files.IndexOf(file) / files.Count), "Cleaning...");
                try
                {
                    File.Delete(file);
                    sw.WriteLine("[ DELETE SUCCESSFUL! :) ]");
                    sw.Flush();
                }
                catch {
                    sw.WriteLine("[ COULD NOT GET FILE :( ]");
                    sw.Flush();
                }
            }

            sw.WriteLine("Folder ready for use!\nBegin resizing images...");
            sw.WriteLine("Images to resize: " + irps.Count);

            Queue<string> pics = new Queue<string>();
            sw.WriteLine();
            foreach (irp thisIrp in irps)
            {
                backgroundWorker1.ReportProgress((100 * irps.IndexOf(thisIrp) / irps.Count), "Shrinking " + (new FileInfo(thisIrp.ToString()).Name));
                Image img = Image.FromFile(thisIrp.PathAsString);
                Bitmap resizedImg = new Bitmap(width, height);

                sw.WriteLine("Attempting to resize " + thisIrp.PathAsString + " {" + img.Size.Width + " X " + img.Size.Height + "} => {" + width.ToString() + " X " + height.ToString() + "}");

                double ratioX = (double)resizedImg.Width / (double)img.Width;
                double ratioY = (double)resizedImg.Height / (double)img.Height;
                double ratio = ratioX < ratioY ? ratioX : ratioY;

                int newHeight = Convert.ToInt32(img.Height * ratio);
                int newWidth = Convert.ToInt32(img.Width * ratio);

                using (Graphics g = Graphics.FromImage(resizedImg))
                {
                    g.DrawImage(img, 0, 0, newWidth, newHeight);
                    sw.WriteLine("[ REDRAW SUCCESSFUL! :) ]");
                }
                resizedImg.Save($@"toEncode\{Directory.GetFiles("toEncode").Length}.gif", System.Drawing.Imaging.ImageFormat.Gif);
                sw.WriteLine("[ IMAGE READY FOR QUEUE ]");
                pics.Enqueue($@"toEncode\{Directory.GetFiles("toEncode").Length}.gif");
                sw.Flush();
                img.Dispose();
                resizedImg.Dispose();
                GC.Collect();
            }

            // Add frames
            sw.WriteLine("\nAll images ready to be used as frames\nBegining to encode...");

            System.Windows.Media.Imaging.GifBitmapEncoder gEnc = new GifBitmapEncoder();
            for (int i = 0; i < Directory.GetFiles("toEncode").Length - 1; i++)
            {
                try
                {
                    var pic = pics.Dequeue();
                    sw.WriteLine("Attempting to add " + pic + " to stream...");
                    Bitmap bmpImage = (Bitmap)Image.FromFile(pic);
                    sw.WriteLine("[ RENDER SUCCESSFUL! :) ]");
                    //var bmp = bmpImage.GetHbitmap();
                    var src = System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(
                        bmpImage.GetHbitmap(),
                        IntPtr.Zero,
                        Int32Rect.Empty,
                        BitmapSizeOptions.FromEmptyOptions());
                    gEnc.Frames.Add(BitmapFrame.Create(src));
                    sw.WriteLine("[ FRAMED SUCCESSFUL! :) ]");
                    //Marshal.FreeHGlobal(bmp);
                    //bmp = IntPtr.Zero;
                    //System.Runtime.InteropServices.Marshal.FreeHGlobal(bmp); // handle memory leak
                    backgroundWorker1.ReportProgress((new List<string>(Directory.GetFiles("toEncode")).IndexOf(pic) * 100) / Directory.GetFiles("toEncode").Length + 1, $"Encoding... [{gEnc.Frames.Count * (Width * Height)} Pixals Loaded]");
                }
                catch(Exception ex)
                {
                    //Dropped Frame
                    sw.WriteLine("[ FRAME DROPPED! ( " + ex.Message + " ) ]");
                }
                finally
                {
                    sw.Flush();
                    GC.Collect();
                }
            }
            using (FileStream fs = new FileStream((e.Argument as object[])[3] as string, FileMode.Create))
            {
                GC.Collect();
                sw.WriteLine("\nSaving GIF to " + (e.Argument as object[])[3] as string);
                gEnc.Save(fs);
                sw.WriteLine("[  DONE! :) ]");
            }
            sw.Flush();
            sw.Close();
            sw.Dispose();
            gEnc = null;
            GC.Collect();
            if (!cb_makedigirec.Checked)
                File.Delete((e.Argument as object[])[3] as string + ".datalog");
            backgroundWorker1.ReportProgress(0, "Ready...");
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                pb_progress.Value = e.ProgressPercentage;
            }
            catch { pb_progress.Value = 0;  }
            l_status.Text = e.UserState as string;
        }

        private void clb_include_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}

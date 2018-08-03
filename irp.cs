//
//Created by Tyler on 6/10/2018.
//
using System;
using System.Drawing;
using System.IO;

namespace Gif_Maker
{
    [System.Xml.Serialization.XmlRoot("IRP")]
	[Serializable]
	public class irp
	{
		public irp() { }
		public FileInfo fi { get { return new FileInfo(this.ToString()); } }
		public string PathAsString { get; set; }
		
		public Bitmap GetImage() {
            GC.Collect();
            try
            {
                if (!this.fi.Exists) return null;
                return new Bitmap(this.ToString());
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Woah There!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation, System.Windows.Forms.MessageBoxDefaultButton.Button1);
            }
            GC.Collect();
            return null;
		}
		
		public void SetPath(string path) {
			PathAsString = path;
		}
		public override string ToString() {
            return this.PathAsString;
		}
	}
}

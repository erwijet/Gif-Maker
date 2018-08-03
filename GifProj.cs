//
//Created by Tyler on 6/10/2018.
//
using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Data;

namespace Gif_Maker
{
	[Serializable]
	public class GifProj
	{
		public PropertySet DataValues { get; set; }
		public string SavePath { get; set; }
        public string SaveName { get; set; }
        public List<irp> irps { get; set; } //Image refrence paths
		
		public GifProj()
		{
            if (irps == null)
			    irps = new List<irp>();
			SavePath = "";
			DataValues = new PropertySet();
            DataValues.SelectedImage = 1;
		}

        public void ValidateIrps()
        {
            /*
			var irplist = irps as List<irp>;
            var oldIrps = irplist;
			foreach (var tIrp in oldIrps) {
				if (tIrp.fi.Exists == false) {
					var epd = new EditPathDialog("Please replace path for " + irplist[irplist.IndexOf(tIrp)].ToString());
					if (epd.ShowDialog() == DialogResult.OK) {
						var toAdd = new irp();
						toAdd.SetPath(epd.SelectedPath);
						irplist[irplist.IndexOf(tIrp)] = toAdd;
					} else irplist.RemoveAt(irplist.IndexOf(tIrp));
				}
			}
			irps = irplist;*/

            List<irp> ValidIrps = new List<irp>();
            foreach (var tIrp in irps)
            {
                if (!tIrp.fi.Exists)
                {
                    if (MessageBox.Show("Error. The path " + tIrp.fi.FullName + " could not be found. Would you like to browse for the file to update the path? If not, the file path will be removed from the project.", "IRP ERROR", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        using (OpenFileDialog ofd = new OpenFileDialog())
                        {
                            ofd.Filter = "images|*.bmp|GIF images|*.gif|JPEG images|*.jpg; *.jpeg; *.jpe; *.jif; *.jfif; *.jfi|PNG images|*.png|TIFF images|*.tiff; *.tif|All files|*.*";
                            if (ofd.ShowDialog() == DialogResult.OK)
                            {
                                if (!File.Exists(ofd.FileName))
                                    ValidateIrps();
                                else
                                {
                                    irp newIrp = new irp();
                                    newIrp.SetPath(ofd.FileName);
                                    ValidIrps.Add(newIrp);
                                }
                            }
                        }
                    }
                }
                else
                    ValidIrps.Add(tIrp);
            }
            irps = ValidIrps;
		}

        public void SaveMe(string path)
        {
            if (path == "") path = SavePath;
            else if (path != SavePath) SavePath = path;
            ValidateIrps();
            var bin = new BinaryFormatter();
            using (FileStream s = File.Create(path))
            {
                bin.Serialize(s, this);
            }
            /*
            System.Xml.Serialization.XmlSerializer xmls = new System.Xml.Serialization.XmlSerializer(typeof(GifProj));
            using (FileStream s = File.Create(path))
            {
                xmls.Serialize(s, this);
            }
            */
        }
        public static GifProj FromFile(FileInfo path)
        {
            return path.Exists ? (new BinaryFormatter()).Deserialize(path.OpenRead()) as GifProj : new GifProj();
        }
		
		public void AddIrp(irp @irp) {
			if (@irp.fi.Exists) 
				(this.irps as List<irp>).Add(@irp);
		}
	}
}

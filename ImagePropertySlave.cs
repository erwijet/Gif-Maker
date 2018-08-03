//
//Created by Tyler on 6/10/2018.
//
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Gif_Maker
{
	/// <summary>
	/// Description of ImagePropertyHandler.
	/// </summary>
	public class ImagePropertySlave
	{
		public GifProj ProjectRefrence { get; set; }
        public PictureBox Display { get; set; }

        public ImagePropertySlave(GifProj proj, PictureBox pb)
        {
            Display = pb;
            this.ProjectRefrence = proj;
            if (proj.DataValues.SelectedImage == 0)
                proj.DataValues.SelectedImage++;
        }
		
        string GetSmallPath(string longPath)
        {
            return longPath;
        }

	    public void RunSlave(out string ImageIndexString,
		                    out string ImageNameString,
		                   out string ImageFormatString,
		                  out string ImageSizeString,
		                 out string ImagePathString) {
                ImageIndexString = ProjectRefrence.DataValues.SelectedImage + "/" + ProjectRefrence.DataValues.TotalImages;
                ImageNameString = (ProjectRefrence.irps as List<irp>)[ProjectRefrence.DataValues.SelectedImage - 1].fi.Name;
                ImageFormatString = (ProjectRefrence.irps as List<irp>)[ProjectRefrence.DataValues.SelectedImage - 1].fi.Extension;
                ImageSizeString = (ProjectRefrence.irps as List<irp>)[ProjectRefrence.DataValues.SelectedImage - 1].fi.Length.ToString();
                ImagePathString = (ProjectRefrence.irps as List<irp>)[ProjectRefrence.DataValues.SelectedImage - 1].fi.FullName;
                irp sIRP = new irp();
                sIRP.SetPath(ImagePathString);
                ImageUpdate(sIRP);
		}

        void ImageUpdate(irp selectedValue)
        {
            Display.Image = selectedValue.GetImage();
        }
	}
}

//
//Created by Tyler on 6/9/2018.
//
using System;
using System.Collections.Generic;

namespace Gif_Maker
{
	[Serializable]
	public class PropertySet
	{
		public enum Property {
			Image_Index,
			Image_Count,
		}
		
		public int TotalImages { get; set; }
		public int SelectedImage { get; set; }

		public PropertySet()
		{
		}
		
		public void DoPropertyUpdate (Property propertyID, object @object) {
			switch (propertyID) {
				case Property.Image_Count:
					break;
				case Property.Image_Index:
					break;
			}
		}
	}
}

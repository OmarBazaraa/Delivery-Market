using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using DeliveryMarket.Utils.Defs;
using System.Windows.Forms;

namespace DeliveryMarket.Utils {

	/*
	 * Contains some helper functions to be used all over the application
	 */
	static class Utility {

		/* Uploads a given image to the specified path in our local system */
		public static string UploadImage(string image, int productID) {
			try {
				string dest = "";

				if (!Directory.Exists(Strings.PRODUCT_IMAGES_DIRECTORY)) {
					Directory.CreateDirectory(Strings.PRODUCT_IMAGES_DIRECTORY);
				}

				FileInfo imageFile = new FileInfo(image);
				dest = Strings.PRODUCT_IMAGES_DIRECTORY + "\\" + productID.ToString() + imageFile.Extension;
				File.Copy(image, dest, true);
				return dest;
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message, Strings.APP_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
				return "";
			}
		}
	}
}

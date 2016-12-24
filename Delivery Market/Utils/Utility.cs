using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using DeliveryMarket.Utils.Defs;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace DeliveryMarket.Utils {

	/*
	 * Contains some helper functions to be used all over the application
	 */
	static class Utility {

		/* Hashes the given password for more security */
		public static string HashPassword(string password) {
			const string salt = "r4Nd0m_5A1t";
			HashAlgorithm algorithm = new SHA256Managed();
			string hashed = Convert.ToBase64String(algorithm.ComputeHash(Encoding.UTF8.GetBytes(password + salt)));
			return hashed.Replace("'", "''");
		}

		/* Checks whether the given string is valid to be a username or not */
		public static bool IsUsernameValidString(string s) {
			foreach (char c in s) {
				if (!char.IsLetterOrDigit(c) && c != '_' && c != '-') {
					return false;
				}
			}
			return true;
		}

		/* Checks whether the given string consists of letters only or not */
		public static bool IsLettersString(string s) {
			foreach (char c in s) {
				if (!char.IsLetter(c)) {
					return false;
				}
			}
			return true;
		}

		/* Checks whether the given string consists of numbers only or not */
		public static bool IsNumericString(string s) {
			foreach (char c in s) {
				if (!char.IsDigit(c)) {
					return false;
				}
			}
			return true;
		}

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

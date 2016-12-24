using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryMarket.Utils {

	/*
	 * Contains some defenitions to be used all over the application
	 */
	namespace Defs {

		public enum Privilege {
			Admin,
			User,
			Banned,
			Other
		}

		public static class Strings {

			// Application global strings
			public const string APP_TITLE = "Delivery Market";

			public const string MAIN_DIRECTORY = "C:\\DeliveryMarket";
			public const string IMAGES_DIRECTORY = MAIN_DIRECTORY + "\\Images";
			public const string PRODUCT_IMAGES_DIRECTORY = IMAGES_DIRECTORY + "\\Products";

			// Applications messages

		}
	}
}
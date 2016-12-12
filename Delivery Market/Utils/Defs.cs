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
			Other
		}

		public static class Strings {

			// Application global strings
			public const string APP_TITLE = "Delivery Market";

			// Applications messages

		}
	}
}
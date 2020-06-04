using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
	sealed class DBAccess
	{

		public const int SQLCMD_TIMEOUT = 15;


		public static string ConnectionString { get; }

		static DBAccess() {
			ConnectionString = ConfigurationManager.ConnectionStrings["DBKey"].ConnectionString;
		}


	}
}

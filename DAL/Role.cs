using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{

	public class Role
	{

		public static Role Read(int id) {
			Role retObj = null;

			using(var con = new SqlConnection(DBAccess.ConnectionString)) {

				var sql = "Select TOP 1 * FROM Roles WHERE id = @p0";

				using(var sqlCmd = new SqlCommand(sql, con)
				{
					CommandTimeout = DBAccess.SQLCMD_TIMEOUT,
					CommandType = System.Data.CommandType.Text
				}) {
					sqlCmd.Parameters.AddWithValue("@p0", id);

					con.Open();

					using(var sqlReader = sqlCmd.ExecuteReader()) {

						while(sqlReader.Read()) {
							retObj = new Role
							{
								Id = (int)sqlReader["id"],
								Name = (string)sqlReader["name"]
							};
						}

					}

				}

			}

			return retObj;
		}


		private Role() { }


		public int Id { get; private set; }
		public string Name { get; private set; }

	}


}

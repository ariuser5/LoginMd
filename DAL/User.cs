using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
	public class User
	{

		public static User Create(string username, string password, string role = "guest") {

			using(var con = new SqlConnection(DBAccess.ConnectionString)) {

				var sql = "INSERT INTO Users VALUES(@p0, @p1, @p2)";

				using(var sqlCmd = new SqlCommand(sql, con)
				{
					CommandTimeout = DBAccess.SQLCMD_TIMEOUT,
					CommandType = System.Data.CommandType.Text
				}) {
					sqlCmd.Parameters.AddWithValue("@p0", username);
					sqlCmd.Parameters.AddWithValue("@p1", password);
					sqlCmd.Parameters.AddWithValue("@p2", role);

					con.Open();
					sqlCmd.ExecuteNonQuery();
				}

			}

			return Read(username);
		}

		public static User Read(string username) {
			User retObj = null;

			using(var con = new SqlConnection(DBAccess.ConnectionString)) {

				var sql = "Select TOP 1 * FROM Users WHERE username = @p0";

				using(var sqlCmd = new SqlCommand(sql, con)
				{
					CommandTimeout = DBAccess.SQLCMD_TIMEOUT,
					CommandType = System.Data.CommandType.Text
				}) {
					sqlCmd.Parameters.AddWithValue("@p0", username);

					con.Open();

					using(var sqlReader = sqlCmd.ExecuteReader()) {

						while(sqlReader.Read()) {
							retObj = new User
							{
								Username = (string)sqlReader["username"],
								Password = (string)sqlReader["password"],
								RoleId = (int)sqlReader["role"]
							};
						}

					}

				}

			}

			return retObj;
		}


		private User() { }



		public string Username { get; private set; }
		public string Password { get; private set; }
		public int RoleId { get; private set; }


		public void Update() {
			throw new NotImplementedException();
		}

		public void Delete() {
			throw new NotImplementedException();
		}


		#region Helpers

		public static bool IsValidUsername(string username) {
			//TODO
			return true;
		}

		public static bool IsValidPassword(string passowrd) {
			//TODO
			return true;
		}

		#endregion


	}
}

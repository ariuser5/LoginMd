using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL
{
	public class UserInfo
	{


		/// <summary>
		/// The "Read" method in CRUD.
		/// </summary>
		/// <param name="username"></param>
		/// <param name="password"></param>
		/// <returns></returns>
		public static UserInfo Login(string username, string password) {
			var daoObj = DAL.User.Read(username);

			return daoObj?.Password == password ?
				   new UserInfo(daoObj) :
				   null;
		}



		private UserInfo(string username, string password) {
			Username = username;
			Password = password;
			Role = null;
		}

		private UserInfo(DAL.User daoObj) :
			this(daoObj.Username, daoObj.Password) {

			Role = DAL.Role.Read(daoObj.RoleId).Name;
		}


		public string Username { get; private set; }
		public string Password { get; private set; }
		public string Role { get; private set; }


		/// <summary>
		/// The "Create" method in CRUD.
		/// </summary>
		public void Register() {

			//TODO
			//Manage primary key collisions.

			if(DAL.User.IsValidUsername(Username) &&
			   DAL.User.IsValidPassword(Password)) {

				DAL.User.Create(Username, Password, Role);

			} else {
				throw new ArgumentException("Invalid credentials.");
			}

		}

		public void Update() {
			throw new NotImplementedException();
		}

		public void Delete() {
			throw new NotImplementedException();
		}



	}
}

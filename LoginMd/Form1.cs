using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginMd
{
	public partial class Form1: Form
	{

		private bool draggingForm = false;
		private Point startPoint = new Point();


		public Form1() {
			InitializeComponent();
		}

		private void btn_login_Click(object sender, EventArgs e) {
			var user = BLL.UserInfo.Login(tb_username.Text, tb_password.Text);

			if(user == null) MessageBox.Show("Failed.");
			else MessageBox.Show("Success.");
		}

		private void Form1_MouseDown(object sender, MouseEventArgs e) {
			draggingForm = true;
			startPoint = new Point(e.X, e.Y);
		}

		private void Form1_MouseUp(object sender, MouseEventArgs e) {
			draggingForm = false;
		}

		private void Form1_MouseMove(object sender, MouseEventArgs e) {
			if(draggingForm) {
				var p = PointToScreen(e.Location);
				Location = new Point(p.X - startPoint.X,
									 p.Y - startPoint.Y);
			}
		}

		private void btn_cancel_Click(object sender, EventArgs e) {
			Application.Exit();
		}


	}
}

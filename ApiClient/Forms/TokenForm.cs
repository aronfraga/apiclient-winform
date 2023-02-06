using System;
using System.Windows.Forms;
using ApiClient.Services;

namespace ApiClient.Forms {
	public partial class TokenForm : Form {

		public TokenForm() {
			InitializeComponent();
			richtxt_token.Text = Token._token;
		}

		private void btn_add_Click(object sender, EventArgs e) {
			Home home = new Home();
			Token._token = richtxt_token.Text;
			this.Close();
		}

	}
}

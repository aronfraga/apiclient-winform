using System;
using System.Drawing;
using System.Windows.Forms;
using ApiClient.Forms;
using ApiClient.Models;
using ApiClient.Services;

namespace ApiClient {
	public partial class Home : Form {

		Method method = new Method();
		Json json = new Json();

		public Home() {
			InitializeComponent();
		}

		private async void btn_get_Click(object sender, EventArgs e) {
			bar.Value = 0;
			timer.Start();
			string url = txtbox_url.Text;
			if (txtbox_url.Text.Length > 0) {
				Resp response = await method.Get(url);
				rich_response.Text = json.Beatify(response.Data);
				StatusCodeChange(response.Code);
			}
			timer.Stop();
			bar.Value = 100;
		}

		private void timer_Tick(object sender, EventArgs e) {
			bar.Increment(10);
		}

		private void btn_token_Click(object sender, EventArgs e) {
			TokenForm tokenForm = new TokenForm();
			tokenForm.ShowDialog();
		}

		private async void btn_post_Click(object sender, EventArgs e) {
			bar.Value = 0;
			timer.Start();
			string url = txtbox_url.Text;
			if (txtbox_url.Text.Length > 0) {
				Resp response = await method.Post(url, rich_body.Text);
				rich_response.Text = json.Beatify(response.Data);
				StatusCodeChange(response.Code);
			}
			timer.Stop();
			bar.Value = 100;
		}

		private async void btn_put_Click(object sender, EventArgs e) {
			bar.Value = 0;
			timer.Start();
			string url = txtbox_url.Text;
			if (txtbox_url.Text.Length > 0) {
				Resp response = await method.Put(url, rich_body.Text);
				rich_response.Text = json.Beatify(response.Data);
				StatusCodeChange(response.Code);
			}
			timer.Stop();
			bar.Value = 100;
		}

		private async void btn_delete_Click(object sender, EventArgs e) {
			bar.Value = 0;
			timer.Start();
			string url = txtbox_url.Text;
			if (txtbox_url.Text.Length > 0) {
				Resp response = await method.Delete(url);
				rich_response.Text = response.Data;
				StatusCodeChange(response.Code);
			}
			timer.Stop();
			bar.Value = 100;
		}

		public void StatusCodeChange(string code) {
			lbl_statuscode.Text = string.Empty;
			switch (code) {
				case "OK":
					lbl_statuscode.Text = 200 + " - " + code;
					lbl_statuscode.ForeColor = Color.Green;
					break;
				case "Created": 
					lbl_statuscode.Text = 201 + " - " + code;
					lbl_statuscode.ForeColor = Color.Green;
					break;
				case "NotFound":
					lbl_statuscode.Text = 404 + " - " + code;
					lbl_statuscode.ForeColor = Color.Red;
					break;
				default:
				lbl_statuscode.Text = code;
				break;
			}
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
			AboutForm about = new AboutForm();
			about.ShowDialog();
		}

	}
}

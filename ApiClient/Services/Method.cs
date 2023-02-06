using ApiClient.Models;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApiClient.Services {
	public class Method {

		public async Task<Resp> Get(string url) {

			HttpClient client = new HttpClient();
			Resp resp = new Resp();
			try {
				if (Token._token != null)
					client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Token._token);

				HttpResponseMessage response = await client.GetAsync(url);
				HttpContent content = response.Content;

				string dataResponse = await content.ReadAsStringAsync();

				resp.Data = dataResponse;
				resp.Code = response.StatusCode.ToString();

				if (dataResponse != null) return resp;

			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return resp;

		}

		public async Task<Resp> Post(string url, string body) {

			HttpClient client = new HttpClient();
			Resp resp = new Resp();
			try {
				if (Token._token != null)
					client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Token._token);

				var content = new StringContent(body.ToString(), Encoding.UTF8, "application/json");

				HttpResponseMessage response = await client.PostAsync(url, content);
				HttpContent ContentResponse = response.Content;

				string jsonContent = ContentResponse.ReadAsStringAsync().Result;

				resp.Data = jsonContent;
				resp.Code = response.StatusCode.ToString();

				if (resp.Data != null) return resp;

			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return resp;

		}

		public async Task<Resp> Put(string url, string body) {

			HttpClient client = new HttpClient();
			Resp resp = new Resp();
			try {
				if (Token._token != null)
					client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Token._token);

				var content = new StringContent(body.ToString(), Encoding.UTF8, "application/json");

				HttpResponseMessage response = await client.PutAsync(url, content);
				HttpContent ContentResponse = response.Content;

				string jsonContent = ContentResponse.ReadAsStringAsync().Result;

				resp.Data = jsonContent;
				resp.Code = response.StatusCode.ToString();

				if (resp.Data != null) return resp;

			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return resp;

		}

		public async Task<Resp> Delete(string url) {

			HttpClient client = new HttpClient();
			Resp resp = new Resp();
			try {
				if (Token._token != null)
					client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Token._token);

				HttpResponseMessage response = await client.DeleteAsync(url);
				HttpContent ContentResponse = response.Content;

				string jsonContent = ContentResponse.ReadAsStringAsync().Result;

				resp.Data = jsonContent;
				resp.Code = response.StatusCode.ToString();

				if (resp.Data != null) return resp;

			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return resp;
		}

	}
}

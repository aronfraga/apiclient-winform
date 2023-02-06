using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ApiClient.Services {
	public class Json {
		
		public string Beatify(string response) { 
			JToken parseJson = JToken.Parse(response);
			return parseJson.ToString(Formatting.Indented);
		}

	}
}

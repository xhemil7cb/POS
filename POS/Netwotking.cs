
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace POS
{


    class Networking
    {

        // All networking data will be handled in this class

        // I will be using this LoginCredentials class only in Networking class scope

        public class JsonLoginResponse
        {
            public bool Loggedin;
            public string Cookie;
        }

        public static async Task<object> Login(string user, string pass)
        {
            var httpClient = new HttpClient();

            var url = "http://127.0.0.1/POSserver/login.php";

            LoginCredentials loginCredentials = new LoginCredentials(user, pass);

            string JSONloginCredentials = JsonConvert.SerializeObject(loginCredentials);


            var response = await httpClient.PostAsync(url, new StringContent(JSONloginCredentials));

            response.EnsureSuccessStatusCode();

            string content = await response.Content.ReadAsStringAsync();

            JsonLoginResponse jsonLoginResponse = JsonConvert.DeserializeObject<JsonLoginResponse>(content);
            MessageBox.Show(jsonLoginResponse.Cookie);

            return jsonLoginResponse.Cookie;




        }



    }
}

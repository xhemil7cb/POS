
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

        class LoginCredentials
        {

            public string Username;
            public string Password;

            public LoginCredentials(string username, string password)
            {
                Username = username;
                Password = password;
            }
        }



        // Login button calls this function
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


       
        class LoginCookie
        {
            public string _LoginCookie;

            public LoginCookie(string _setLoginCookie)
            {
                _LoginCookie = _setLoginCookie;
            }
        }

        class CheckLoginCookieResponse
        {
            public bool Valid;
        }

         public static async Task<bool> CheckCookieValidityAsync(string _LoginCookie)
        {

            var httpClient = new HttpClient();

            var url = "http://127.0.0.1/POSserver/checklogincookie.php";

            LoginCookie loginCookie = new LoginCookie(_LoginCookie); 

            
            string JSONloginCookie = JsonConvert.SerializeObject(loginCookie);


            var response = await httpClient.PostAsync(url, new StringContent(JSONloginCookie));

            response.EnsureSuccessStatusCode();

            string content = await response.Content.ReadAsStringAsync();
 
            CheckLoginCookieResponse jsonLoginCookieResponse = JsonConvert.DeserializeObject<CheckLoginCookieResponse>(content);
            MessageBox.Show(jsonLoginCookieResponse.Valid.ToString());

            return jsonLoginCookieResponse.Valid;
        }



    }
}

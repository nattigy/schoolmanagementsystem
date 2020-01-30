using System.Windows;
using FireSharp;
using FireSharp.Interfaces;
using FireSharp.Response;
using sms.Models;
using sms.Utils;
using Task = System.Threading.Tasks.Task;

namespace sms.Authentication
{
    public class AuthenticateUser
    {
        private readonly IFirebaseClient _client;
        private FirebaseResponse _firebaseResponse;

        public AuthenticateUser(IFirebaseConfig config)
        {
            _client = new FirebaseClient(config);
        }

        public void Login()
        {
        }

        public async Task Signup(Admin newAdmin)
        {
            if (ConnectionUtil.CheckConnection())
            {
                _firebaseResponse = await _client.GetAsync("Admin/" + newAdmin.UserName);
                var foundUser = _firebaseResponse.ResultAs<User>();
                if (foundUser == null)
                {
                    var response = await _client.SetAsync("Admin/" + newAdmin.UserName, newAdmin);
                    var admin = response.ResultAs<Admin>();
                    MessageBox.Show(admin.UserName);
                }
                else
                {
                    MessageBox.Show("Username taken");
                }
            }
            else
            {
                MessageBox.Show("error");
            }
        }
    }
}
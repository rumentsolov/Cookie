using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookie.Services
{
    public class AuthService
    {
        public const string AuthStateKey = "AuthState";
        public async Task<bool> IsAuthenticatedAsync() // string username, string password
        {
            await Task.Delay(2000);

            var authService = Preferences.Default.Get<bool>(AuthStateKey, false);

            return authService;
        }

        public void LogIn()
        {
            Preferences.Default.Set<bool>(AuthStateKey, true);
        }

        public void LogOut()
        {
            Preferences.Default.Set<bool>(AuthStateKey, false);
        }
    }
}

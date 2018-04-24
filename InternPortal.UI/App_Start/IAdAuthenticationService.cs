using System.DirectoryServices.AccountManagement;
using InternPortal.UI.Models;

namespace InternPortal.UI.App_Start
{
    public interface IAdAuthenticationService
    {
        AuthenticationResult SignIn(string username, string password, ContextType contextType,
           string activeDirectoryLocation);
        AuthenticationResult Authenticate(string username, string password, ContextType contextType,
            string activeDirectoryLocation);
        void SignOut(string applicationCookie);
    }
}
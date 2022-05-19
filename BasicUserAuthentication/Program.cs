using System;
using Microsoft.Identity.Client;

namespace BasicUserAuthentication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var clientID = "cc327a90-2c2d-4be2-b294-c044f49adadb";
            var redirectURI = "https://login.microsoftonline.com/common/oauth2/nativeclient";
            string[] scopes = { "User.Read", "OnlineMeetings.ReadWrite" };

            var client = PublicClientApplicationBuilder.Create(clientID)
                .WithAuthority(AadAuthorityAudience.AzureAdAndPersonalMicrosoftAccount)
                .WithRedirectUri(redirectURI)
                .Build();

            var token = client.AcquireTokenInteractive(scopes).ExecuteAsync().Result;
            Console.WriteLine(token);
        }
    }
}

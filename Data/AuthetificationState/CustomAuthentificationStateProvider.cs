﻿namespace Contrat_AC.Data.AuthetificationState
{
    //using Blazored.LocalStorage;
    using Contrat_AC.Models.Autorisation;
    using Microsoft.AspNetCore.Components.Authorization;
    using System.Security.Claims;
    using System.Threading.Tasks;

    namespace LYRA.Data
    {
        public class CustomAuthenticationStateProvider : AuthenticationStateProvider
        {
            public CustomAuthenticationStateProvider()
            {
                
            }

            public override Task<AuthenticationState> GetAuthenticationStateAsync()
            {
                throw new NotImplementedException();
            }
            //private readonly ILocalStorageService _localStorageService;

            //public CustomAuthenticationStateProvider(ILocalStorageService localStorageService)
            //{
            //    _localStorageService = localStorageService;
            //}

            //public override async Task<AuthenticationState> GetAuthenticationStateAsync()
            //{
            //    var emailAddress = await _localStorageService.GetItemAsync<string>("emailAddress");
            //    List<string> roles = await _localStorageService.GetItemAsync<List<string>>("roles");
            //    var nom = await _localStorageService.GetItemAsync<string>("loginNom");
            //    var prenom = await _localStorageService.GetItemAsync<string>("loginPrenom");
            //    ClaimsIdentity identity;

            //    if (emailAddress != null)
            //    {
            //        var claims = new List<Claim>
            //    {
            //        new Claim(ClaimTypes.Email, emailAddress),
            //    };
            //        foreach (var item in roles)
            //        {
            //            claims.Add(new Claim(ClaimTypes.Role, item));
            //        }
            //        identity = new ClaimsIdentity(claims, "apiauth");
            //    }
            //    else
            //    {
            //        identity = new ClaimsIdentity();
            //    }
            //    var user = new ClaimsPrincipal(identity);

            //    return await Task.FromResult(new AuthenticationState(user));
            //}

            //public void MarkUserAsAuthenticated(User utilisateur, List<string> uroles)
            //{
            //    ClaimsIdentity identity;
            //    var claims = new List<Claim>
            //{
            //    new Claim(ClaimTypes.Email, utilisateur.AdressMail)
            //};

            //    foreach (var item in uroles)
            //    {
            //        claims.Add(new Claim(ClaimTypes.Role, item));
            //    }
            //    identity = new ClaimsIdentity(claims, "apiauth");

            //    var user = new ClaimsPrincipal(identity);

            //    NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
            //}

            //public async void MarkUserAsLoggedOut()
            //{
            //    await _localStorageService.ClearAsync();
            //    var identity = new ClaimsIdentity();
            //    var user = new ClaimsPrincipal(identity);
            //    NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
            //}

        }
    }
}

using System.Collections.Generic;
using System.Security.Claims;
using IdentityServer4.Models;
using IdentityServer4.Test;

namespace EcovadisIdp
{
    public static class Config
    {
        public static List<TestUser> GetUsers()
        {
            return new List<TestUser>()
            {
                new TestUser
                {
                    SubjectId = "d860efca-22d9-47fd-8249-791ba61b07c7",
                    Username = "Frank",
                    Password = "password",
                    Claims = new List<Claim>
                    {
                        new Claim("given_name", "Frank"),
                        new Claim("family_name", "Underwood")
                    }
                }
            };
        }

        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new List<IdentityResource>()
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile()
            };
        }

        public static List<Client> GetClients()
        {
            return new List<Client>();
        }
    }
}

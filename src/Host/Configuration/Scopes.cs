﻿using IdentityServer4.Core.Models;
using System.Collections.Generic;

namespace Host.Configuration
{
    public class Scopes
    {
        public static IEnumerable<Scope> Get()
        {
            return new List<Scope>
            {
                StandardScopes.OpenId,
                StandardScopes.Profile,
                StandardScopes.Email,
                StandardScopes.OfflineAccess,

                new Scope
                {
                    Name = "roles",
                    Type = ScopeType.Identity,
                    Claims = new List<ScopeClaim> {
                        new ScopeClaim("role")
                    }
                },

                new Scope
                {
                    Name = "api1",
                    Type = ScopeType.Resource,

                    ScopeSecrets = new List<Secret>
                    {
                        new Secret("secret".Sha256())
                    }
                },
                new Scope
                {
                    Name = "api2",
                    Type = ScopeType.Resource
                }
            };
        }
    }
}
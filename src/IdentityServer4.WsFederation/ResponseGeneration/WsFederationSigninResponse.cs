﻿using IdentityServer4.WsFederation.Validation;
using Microsoft.IdentityModel.Protocols.WsFederation;

namespace IdentityServer4.WsFederation
{
    public class WsFederationSigninResponse
    {
        public ValidatedWsFederationRequest Request { get; set; }
        public WsFederationMessage ResponseMessage { get; set; }
    }
}

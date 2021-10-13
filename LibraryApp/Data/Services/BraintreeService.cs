using Braintree;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApp.Data.Services
{
    public class BraintreeService : IBraintreeService
    {
        private readonly IConfiguration _config;
        public BraintreeService(IConfiguration config)
        {
            _config = config;
        }

        public IBraintreeGateway CreateGateway()
        {
            var newGateway = new BraintreeGateway
            {
                Environment = Braintree.Environment.SANDBOX,
                MerchantId = "yvgkhn9x4ss9t3qj",
                PublicKey = "pcg3f64tx6bwbsd8",
                PrivateKey = "734b12367b7c4b94ace00161f783022f"
            };

            return newGateway;
        }

        public IBraintreeGateway GetGateway()
        {
            return CreateGateway();
        }
    }
}

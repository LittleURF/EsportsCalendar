using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Authenticators;

namespace EsportsCalendar.Services
{
    public class PandaApi : IPandaApi
    {
        private readonly RestClient _client = new RestClient("https://api.pandascore.co");
        private readonly string _accessToken = "QYA0Ct1kmILVEbaNn8smxE3OYNbfVUIyhvMpDFmXa8BALFGLitk";

        public PandaApi()
        {
            _client.Authenticator = new JwtAuthenticator(_accessToken);
        }

    }
}

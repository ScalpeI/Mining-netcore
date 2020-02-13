using MiningUpdate.Concrete;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace MiningUpdate.Model
{
    class RequestRate
    {
        public async void Upload()
        {
            EFRateRepository repository = new EFRateRepository();
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            var req = WebRequest.Create("https://nl.bitstamp.net/api/ticker/");
            var r = await req.GetResponseAsync();
            StreamReader responseReader = new StreamReader(r.GetResponseStream());
            var responseData = await responseReader.ReadToEndAsync();
            Rate rate = JsonConvert.DeserializeObject<Rate>(responseData);
           // repository.SaveRate(rate);
        }
    }
}

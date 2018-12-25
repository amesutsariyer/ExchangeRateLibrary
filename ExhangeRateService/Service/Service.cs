using ExhangeRateService.Entity;
using ExhangeRateService.Interface;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ExhangeRateService.Service
{
    public class Service : IService
    {
        public ResponseModel Get()
        {
            try
            {
                string url = "http://www.tcmb.gov.tr/kurlar/today.xml";
                string strResponse2 = string.Empty;
                //alternative url
                //HttpWebRequest req = WebRequest.Create(url) as HttpWebRequest;
                using (var client = new WebClient())
                {
                    strResponse2 = client.DownloadString(url);
                }

                XmlSerializer serializer = new XmlSerializer(typeof(ExchangeRate));
                MemoryStream memStream = new MemoryStream(Encoding.UTF8.GetBytes(strResponse2));
                var data = (ExchangeRate)serializer.Deserialize(memStream);
                return new ResponseModel() { Result = data, Status = true };
            }
            catch (Exception ex)
            {
                return new ResponseModel() { Result = null, Status = false };
            }
        }
        public ResponseModel GetCurrency(string from_currency ="USD")
        {
            string url = $"https://www.alphavantage.co/query?function=CURRENCY_EXCHANGE_RATE&from_currency={from_currency}&to_currency=TRY&apikey=6AF006IJKXYADKV0";
            string responseModel = string.Empty;

            try
            {
                using (var client = new WebClient())
                {
                    responseModel = client.DownloadString(url);
                }
                AlphavantageBaseModel response =   JsonConvert.DeserializeObject<AlphavantageBaseModel>(responseModel);
               
                return new ResponseModel() { Result = response, Status = true };
            }
            catch (Exception ex)
            {
                return new ResponseModel() { Result = null, Status = false };
            }
        }
    }
}

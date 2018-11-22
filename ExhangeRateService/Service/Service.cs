using ExhangeRateService.Entity;
using ExhangeRateService.Interface;
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
    }
}

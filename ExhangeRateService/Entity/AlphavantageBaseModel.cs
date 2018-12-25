using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExhangeRateService.Entity
{
    public class AlphavantageBaseModel
    {
        [JsonProperty("Realtime Currency Exchange Rate")]
        public AlphavantageModel AlphavantageModel{ get; set; }
       
    }
}

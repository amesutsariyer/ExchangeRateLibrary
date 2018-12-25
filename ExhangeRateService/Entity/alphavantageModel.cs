using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExhangeRateService.Entity
{

    public class AlphavantageModel
    {
        [JsonProperty("1. From_Currency Code")]
        public string FromCode{ get; set; }
        [JsonProperty("2. From_Currency Name")]
        public string FromName{ get; set; }
        [JsonProperty("3. To_Currency Code")]
        public string ToCode{ get; set; }
        [JsonProperty("4. To_Currency Name")]
        public string ToName{ get; set; }
        [JsonProperty("5. Exchange Rate")]
        public string Exchange_Rate{ get; set; }
        [JsonProperty("6. Last Refreshed")]
        public string Last_Refreshed{ get; set; }
        [JsonProperty("7. Time Zone")]
        public string Time_Zone{ get; set; }
    }
}

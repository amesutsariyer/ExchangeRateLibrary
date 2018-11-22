using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ExhangeRateService.Entity
{
    [Serializable()]
    [System.Xml.Serialization.XmlRoot("Tarih_Date")]
    public class ExchangeRate
    {
        [XmlElement("Currency")]
        public List<Currency> Currency{ get; set; }
    }
    [Serializable()]
    public class Currency
    {
        public int Unit { get; set; }

        public string Isim { get; set; }

        public string CurrencyName { get; set; }

        public string ForexBuying { get; set; }

        public string ForexSelling { get; set; }

        public string BanknoteBuying { get; set; }

        public string BanknoteSelling { get; set; }

        public string CrossRateUSD { get; set; }

        public string CrossRateOther { get; set; }
    }
}

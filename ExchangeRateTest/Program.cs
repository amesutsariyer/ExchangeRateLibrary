using ExhangeRateService.Entity;
using ExhangeRateService.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeRateTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ExchangeRateService exchangeService = new ExchangeRateService();
            var model = exchangeService.GetLiveCurrency();

        }
    }
}

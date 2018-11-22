using ExhangeRateService.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExhangeRateService.Service
{
    
    public class ExchangeRateService : IExchangeRateService
    {
        private readonly Service _service;
        public ExchangeRateService()
        {
            _service = new Service();
        }
    }
}

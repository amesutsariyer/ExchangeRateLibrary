using ExhangeRateService.Entity;
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
        public ResponseModel GetAllCurrency()
        {
          return _service.Get();
        }
        public ResponseModel GetLiveCurrency()
        {
            try
            {
                List<string> currencyList = new List<string>();
                List<AlphavantageBaseModel> model = new List<AlphavantageBaseModel>();
                currencyList.Add("USD");
                currencyList.Add("EUR");
                currencyList.Add("GBP");
                foreach (var cl in currencyList)
                {
                    model.Add(_service.GetCurrency(cl).Result as AlphavantageBaseModel);
                }
                return new ResponseModel()
                {
                    Status=true,
                    Result =model
                };
            }
            catch ( Exception ex)
            {
                return new ResponseModel()
                {
                     Status = false,
                     Result = ex.Message
                };
            }
        }
    }
}

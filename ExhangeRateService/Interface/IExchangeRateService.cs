using ExhangeRateService.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExhangeRateService.Interface
{
    public interface IExchangeRateService
    {
        ResponseModel GetAllCurrency();
        ResponseModel GetLiveCurrency();
    }

}

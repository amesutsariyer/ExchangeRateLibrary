using ExhangeRateService.Entity;
namespace ExhangeRateService.Interface
{
    public interface IService
    {
        ResponseModel Get();
        ResponseModel GetCurrency(string from_currency);
    }
}

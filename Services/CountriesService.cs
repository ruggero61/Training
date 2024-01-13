using ServiceContracts;
using ServiceContracts.DTO;
using Services.Helpers;

namespace Services;
public class CountriesService : ICountriesService
{
    public CountryResponse? AddCountry(CountryAddRequest? countryAddRequest)
    {
        if(countryAddRequest == null)
        {
            throw new ArgumentNullException(nameof(countryAddRequest));
        }
        
        ValidationHelper.ModelValidation(countryAddRequest);
        
        return null;
    }
}

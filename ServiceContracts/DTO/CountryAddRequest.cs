using ServiceContracts.Enums;
using System.ComponentModel.DataAnnotations;
using Entities;

namespace ServiceContracts.DTO;
public class CountryAddRequest
{
    [Required(ErrorMessage = "Country Name can't be blank...")]
    public string? Name { get; set; }
    [Required(ErrorMessage = "Country Code can't be blank...")]
    public string? Code { get; set; }
    public Continent? Continent { get; set; }
    public Currency? Currency { get; set; }
    public Country? ToCountry()
    {
        return new Country
        {
            Name = this.Name,
            Code = this.Code,
            Continent = this.Continent.ToString(),
            Currency = this.Currency.ToString()
        };
    }
}

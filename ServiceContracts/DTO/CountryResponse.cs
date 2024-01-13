using Entities;
using ServiceContracts.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceContracts.DTO;
public class CountryResponse
{
    public int? Id { get; set; }
    public string? Name { get; set; }
    public string? Code { get; set; }
    public string? Currency { get; set; }
    public string? Continent { get; set; }
}


public static class CountryExtension
{
    public static CountryResponse ToCountryResponse(this Country country)
    { 
        return new CountryResponse
        {
            Id = country.Id,
            Name = country.Name,
            Code = country.Code,
            Currency = country.Currency,
            Continent = country.Continent
        };
    }
}

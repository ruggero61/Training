﻿using ServiceContracts.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceContracts;
public interface ICountriesService
{
    public CountryResponse? AddCountry(CountryAddRequest? countryAddRequest);
}

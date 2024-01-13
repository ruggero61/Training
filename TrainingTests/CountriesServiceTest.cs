using ServiceContracts;
using ServiceContracts.DTO;
using Services;
using Xunit.Abstractions;


namespace TrainingTests;
public class CountriesServiceTest
{
    private readonly ICountriesService? _countriesService;
    private readonly ITestOutputHelper? _testOutputHelper;

    public CountriesServiceTest(ITestOutputHelper testOutputHelper)
    {
        _countriesService = new CountriesService();
        _testOutputHelper = testOutputHelper;
    }

    [Fact]
    public void AddCountry_NullCountryAddRequest_ThrowsArgumentNullException()
    {
        // Arrange
        CountryAddRequest? countryAddRequest = null;
        // Act
        Action act = () => _countriesService?.AddCountry(countryAddRequest);
        // Assert
        Assert.Throws<ArgumentNullException>(act);
        _testOutputHelper?.WriteLine("Test passed");
    }
}

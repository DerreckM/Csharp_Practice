using Xunit;
using Prime.Services;

namespace Prime.UnitTests.Services
{
    public class PrimeService_IsPrimeShould
    {
        private readonly PrimeService _primeService;

        public PrimeService_IsPrimeShould()
        {
            _primeService = new PrimeService();
        }

        [Fact]
	public bool IsPrime(int candidate)
	{
    		if (candidate == 1)
    		{
        		return false;
    		}
    		throw new NotImplementedException("Please create a test first");
	}	
    }
}

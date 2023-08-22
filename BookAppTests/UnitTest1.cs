using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Http;
using System.Threading.Tasks;

namespace BookAppTests
{
    [TestClass]
    public class BooksControllerTests
    {
        private const string BaseUrl = "https://localhost:7097"; // Assuming the base URL is for the books API

        [TestMethod]
        public async Task ReturnsOkStatusCodeForGetBooksEndpoint()
        {
            using (var client = new HttpClient())
            {
                // Send a GET request to the /books endpoint
                var response = await client.GetAsync($"{BaseUrl}/books");

                // Assert that the response status code is 'Ok'
                Assert.AreEqual(System.Net.HttpStatusCode.OK, response.StatusCode, "GET request did not return 'Ok' status code.");
            }
        }
    }
}
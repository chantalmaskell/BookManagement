using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Http;
using System.Threading.Tasks;

namespace BookAppTests
{
    [TestClass]
    public class UnitTest1
    {
        private const string BaseUrl = "https://localhost:7097/update-book-status";

        [TestMethod]

        // this cant run without running the project, however you cant run tests when project is being run
        public async Task UpdatesBookStatus()
        {
            using (var client = new HttpClient())
            {
                var content = new StringContent("{\"book_id\": 5, \"newHasbeenread\": 1}", System.Text.Encoding.UTF8, "application/json");

                var response = await client.PutAsync($"{BaseUrl}/update-book-status", content);

                Assert.IsTrue(response.IsSuccessStatusCode, "POST request was not successful.");
            }
        }
    }
}

using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using ContactsMvcApp.Models;
using System.Collections.Generic;

namespace ContactsMvcApp.Services
{
    //The ApiService class provides functionalities to communicate with an external API.
    //It encapsulates the logic for making HTTP requests and processing responses, specifically to fetch contacts.

    public class ApiService
    {
        //HttpClient, which is the main class used for sending HTTP requests and receiving responses.
        private readonly HttpClient _httpClient;

        public ApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        //asynchronous method that returns a list (IEnumerable) of Contact objects.
        public async Task<IEnumerable<Contact>> GetContactsAsync()
        {

            //The response from the server is stored in the response variable.
            var response = await _httpClient.GetAsync("/api/Contacts");

            //asynchronous method that returns a list (IEnumerable) of Contact objects.
            return await response.Content.ReadFromJsonAsync<IEnumerable<Contact>>();
        }
    }
}

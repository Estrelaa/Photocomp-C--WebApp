using RestSharp;

namespace Photocomp.API.Handler
{
    class CallAPI
    {
        public string Call(string URL)
        {
            var client = new RestClient();
            var request = new RestRequest(URL, DataFormat.Json);

            var response = client.Get(request);

            return response.Content;
        }
    }
}

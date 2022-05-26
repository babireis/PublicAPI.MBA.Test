using RestSharp;

namespace PublicAPI.MBA.Test.Infraestrutura.Repositories
{
    public class CalculaIdadeRepository
    {
        private string baseUrl = "https://api.agify.io/";
        private RestClient client;

        public IRestResponse GetCalculoIdade(string name)
        {
            client = new RestClient(baseUrl);
            var request = new RestRequest(Method.GET);
            request.AddQueryParameter("name", name);
            var response = client.Execute(request);
            return response;
        }
    }
}

using FluentAssertions;
using Newtonsoft.Json;
using NUnit.Framework;
using PublicAPI.MBA.Test.Infraestrutura.Models;
using PublicAPI.MBA.Test.Infraestrutura.Repositories;
using RestSharp;
using TechTalk.SpecFlow;

namespace PublicAPI.MBA.Test.Run.StepDefinitions
{
    [Binding]
    public class StepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private CalculoIdadeResponse _calculoIdadeResponse;
        private IRestResponse _response;

        public StepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        
        [When(@"faço o calculo da idade de (.*)")]
        public void QuandoFacoOCalculoDaIdadeDe(string name)
        {
            var repository = new CalculaIdadeRepository();
            _response = repository.GetCalculoIdade(name);
        }

        [Then(@"devo obter o status (.*) da API")]
        public void EntaoDevoObterOStatusDaAPI(int expectedStatus)
        {
            Assert.AreEqual(expectedStatus,(int)_response.StatusCode);            
        }

        [Then(@"devo obter a idade (.*)")]
        public void EntaoDevoObterAIdade(int expectedAge)
        {
            _calculoIdadeResponse = JsonConvert.DeserializeObject<CalculoIdadeResponse>(_response.Content);
            Assert.AreEqual(expectedAge,_calculoIdadeResponse.Age);
        }

        [Then(@"devo obter a mensagem (.*)")]
        public void ThenDevoObterAMensagem(string expectedMessage)
        {
            _response.Content.Should().Contain(expectedMessage);
        }

    }

}

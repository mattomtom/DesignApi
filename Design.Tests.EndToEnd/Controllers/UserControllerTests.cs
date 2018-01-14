using System.Net.Http;

namespace Design.Tests.EndToEnd.Controllers
{

    //TODO 
    public class UserControllerTests
    {
        private readonly TestServer _server;
        private readonly HttpClient _client;

        public UserControllerTests()
        {
            _server = new TestServer(new WebHostBuilder()
            .UseStartup<Startup>());
            _client = _server.CreateClient();
        }
    }
}
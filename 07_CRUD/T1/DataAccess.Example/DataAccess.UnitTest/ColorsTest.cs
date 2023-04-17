using DataAccess.Example.EntityFramework;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;

namespace DataAccess.UnitTest
{
    [TestFixture]

    public class ColorsTest
    {
        protected TestServer _server;

        [OneTimeSetUp]
        public void Setup()
        {
            this._server = new TestServer( new WebHostBuilder().UseStartup<Startup>() );
        }

        [Test]
        public void GetAllColors_Test()
        {
            var repository = _server.Host.Services.GetService<IVehiclesDataManager>();
            var list = repository.GetAll();

            Assert.Pass();
        }
    }
}
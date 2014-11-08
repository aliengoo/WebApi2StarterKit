namespace WebApi2Starter.Controllers
{
    using Mcs.Controllers;
    using Mcs.Repositories;

    public class NasdaqQueryController : MongoQueryController
    {
        public NasdaqQueryController(IMongoRepository mongoRepository)
            : base(mongoRepository, "nasdaq")
        {
        }
    }
}
namespace WebApi2Starter.Controllers
{
    using Mcs.Controllers;
    using Mcs.Repositories;

    public class NasdaqController : MongoCrudController
    {
        public NasdaqController(IMongoRepository mongoRepository)
            : base(mongoRepository, "nasdaq")
        {
        }
    }
}
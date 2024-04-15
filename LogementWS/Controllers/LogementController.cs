using System.Collections.Generic;
using LogementWS.Services;
using Microsoft.AspNetCore.Mvc;

namespace LogementWS.Controllers
{
    // V2 iss99 hyyuy

    // first comment for V2
    // second comment for V2 iss 21212
    [Route("api/[controller]")]
    [ApiController]
    public class LogementController : ControllerBase
    {

        private readonly LogementService logementService;

        public LogementController (LogementService logementService)
        {
            this.logementService = logementService;
        }

        [HttpGet]
        public IEnumerable<Logement> Get()
        {
            Logement l1 = new Logement();
            l1.Description = "Super logement à découvrir";
            l1.Prix = 42.0f;
            l1.Lieu = "casa";

            Logement l2 = new Logement();
            l2.Description = "Belle villa";
            l2.Prix = 56.0f;
            l2.Lieu = "Blois";

            Logement l3 = new Logement();
            l3.Description = "Avec piscine un grand logement";
            l3.Prix = 78.0f;
            l3.Lieu = "Paris";

            return new List<Logement> { l1, l2, l3 };

          //  return logementService.Get();
        }
    }
}

using System.Collections.Generic;
using LogementWS.Services;
using Microsoft.AspNetCore.Mvc;

namespace LogementWS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]


    ///  toto
    public class LogementController : ControllerBase
    {


        // commp

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
            l1.Lieu = "Orléans";

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

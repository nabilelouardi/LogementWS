using System.Collections.Generic;
using LogementWS.Services;
using Microsoft.AspNetCore.Mvc;
//MODIFICATION
namespace LogementWS.Controllers
{
     
    //ZINEBUP  loubna commet   dounia  neo amine 

    // V2 iss99 hyyuy//hicham
    //karima2002

    //MAJORAMINE TEST (((999(((

    // V2 iss99 hyyuy//hicham     neos


    //mac  fati sfirst comment for V2   neo
    // second comment for V2 iss 21212
    // hello there V2
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
            l1.Description = "Super logement yassine à découvrir";
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

          //  return  bbbbbbb logementService.Get();

          // hell nah ayoub ez
          

        }
    }
}

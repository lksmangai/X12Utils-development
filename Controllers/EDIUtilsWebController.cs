using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EDIUtilsWeb.Controllers
{
    [ApiController]
    [Route("[controller]/[action]/")]
    //[Route("[controller]")]
    public class EDIUtilsWebController : ControllerBase
    {
        private readonly ILogger<EDIUtilsWebController> _logger;

        public EDIUtilsWebController(ILogger<EDIUtilsWebController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [ActionName("")]
        public String IndexPage()
        {
            return "Wellcome to RxEligibility";
        }

        [HttpGet]
        [ActionName("Input270")]
        public IEnumerable<EDIInput270> Input270()
        {
            var rng = new Random();
            return Enumerable.Range(1, 1).Select(index => new EDIInput270
            {

            })
            .ToArray();
        }

        [HttpGet]
        [ActionName("Input271")]
        public IEnumerable<EDIInput271> Input271()
        {
            var rng = new Random();
            return Enumerable.Range(1, 2).Select(index => new EDIInput271
            {
                ediItem = (index == 1 ?
                 "ISA00          01OT0J7UA5W5ZZS00000000000001ZZT000000000203151911242342005016785799721T>GSHBS00000000000001T000000000203152019112423421X005010X279A1ST2710001005010X279A1BHT00221111252019111420557201911242342HL1201NM12B2RXHUBPBMPIT00000000001000HL21211NM11P1BestWaynewXX5627182012REFEOT00000000020315HL32220NM1IL1SCHNURBERTLMIG000000%111111116%001REFHJ111111116REF49001N3312 HILL ROADN4HILLSBOROMO63050DMGD819450419MINSY18EB130PLAN101REF6PG000000HONEYWELLREFFOFSL101REFALSALT101REFIGCOP102EB188RTL101DTP291RD820100801-20991231EB190EB1LTC101DTP291RD820100501-20991231MSGLTCSE270001ST2710002005010X279A1BHT00221111252019111420557201911242342HL1201NM12B2RXHUBPBMPIT00000000001000HL21211NM11P1BestWaynewXX5627182012REFEOT00000000020315HL32220NM1IL1SCHNURBERTLMIRBRXHBTTC1RXHBM500101REF4901N3312 HILL ROADN4HILLSBOROMO63050DMGD819450419MEB130PLANXREF181234REF6PTTC1TEST MATCH 1REFFOFSL102REFCLICOV102REFN6610415REFIGCOP102DTP291RD820100801-20991231EB188EB190SE240002ST2710003005010X279A1BHT00221111252019111420557201911242342HL1201NM12B2RXHUBPBMPIT00000000001000HL21211NM11P1BestWaynewXX5627182012REFEOT00000000020315HL32220NM1IL1MIAA112345678900EB630DTP291D820100801SE120003GE31IEA1678579972"
                 :
                 "ISA00          01OT0J7UA5W5ZZS00000000000001ZZT000000000203151911242340005016785790721T>GSHBS00000000000001T000000000203152019112423401X005010X279A1ST2710001005010X279A1BHT00221111252019111232531201911242340HL1201NM12B2SURESCRIPTS LLCPIS00000000000001HL21211NM11P1BestWaynewXX5627182012REFEOT00000000020315N3204 1361 K ST SE APT 204N4WashingtonDC20030HL32220NM1IL1REFEJ100851442180433077AAAY75NDTP291D820191125EBV30SE160001GE11IEA1678579072"
                 )

            })
            .ToArray();
        }
        [HttpGet]
        [ActionName("Input")]
        public IEnumerable<EDIInput> Input()
        {
            var rng = new Random();
            return Enumerable.Range(1, 1).Select(index => new EDIInput
            {
                RxhubURL = "https://switch-cert02.rxhub.net/rxhub",
                RxHubAuthorization = "T00000000020315:FXTXGJVZ0W"
            })
            .ToArray();
        }
        public EDIOutput270 Get270(EDIInput270 ediInputItem)
        {
            EDIUtils ediUtils = new EDIUtils();
            EDIOutput270 ediOutputItem = new EDIOutput270();
            string strControler = "";

            ediOutputItem.ediItem = ediUtils.Write270(ediInputItem.SurescriptsPassword,
            ediInputItem.SurescriptsParticipantId,
            ediInputItem.Staging,

             ediInputItem.PatientProviderLastName,
             ediInputItem.PatientProviderFirstName,
             ediInputItem.PatientProviderMiddleName,
             ediInputItem.PatientProviderSuffix,
             ediInputItem.PatientProviderNPI,
             ediInputItem.PatientProviderDEA,
             ediInputItem.PatientProviderAddressLine1,
             ediInputItem.PatientProviderAddressLine2,
             ediInputItem.PatientProviderAddressCity,
             ediInputItem.PatientProviderAddressState,
             ediInputItem.PatientProviderAddressZip,

             ediInputItem.PatientID,
             ediInputItem.PatientLastName,
             ediInputItem.PatientFirstName,
             ediInputItem.PatientMiddleName,
             ediInputItem.PatientAddressLine1,
             ediInputItem.PatientAddressLine2,
             ediInputItem.PatientAddressCity,
             ediInputItem.PatientAddressState,
             ediInputItem.PatientAddressZip,
             ediInputItem.PatientDOB,
             ediInputItem.PatientGender, out strControler);

            ediOutputItem.strControlNo = strControler;

            return ediOutputItem;
        }
        [HttpPost]
        [ActionName("Get270")]
        public CreatedAtActionResult Post270(EDIInput270 EdiInputItem)
        {
            var ediItem = Get270(EdiInputItem);
            return CreatedAtAction(nameof(Get270), new { id = 1 }, ediItem);
        }

        public EDIOutput271 Get271(EDIInput271 ediInputItem)
        {
            EDIUtils ediUtils = new EDIUtils();
            bool Send270UsingDEA = ediInputItem.Send270UsingDEA;
            EDIOutput271 ediOutputItem = ediUtils.Read271(ediInputItem.ediItem, ref Send270UsingDEA);

            return ediOutputItem;
        }

        [HttpPost]
        [ActionName("Parse271")]
        public CreatedAtActionResult Post271(EDIInput271 EdiInputItem)
        {
            var ediItem = Get271(EdiInputItem);
            return CreatedAtAction(nameof(Get271), new { id = 1 }, ediItem);
        }
        public EDIOutput271 Send270AndGet271(EDIInput ediInputItem)
        {
            EDIUtils ediUtils = new EDIUtils();

            string strControler = "";

            string edi270 = ediUtils.Write270(ediInputItem.SurescriptsPassword,

             ediInputItem.SurescriptsParticipantId,
             ediInputItem.Staging,

             ediInputItem.PatientProviderLastName,
             ediInputItem.PatientProviderFirstName,
             ediInputItem.PatientProviderMiddleName,
             ediInputItem.PatientProviderSuffix,
             ediInputItem.PatientProviderNPI,
             ediInputItem.PatientProviderDEA,
             ediInputItem.PatientProviderAddressLine1,
             ediInputItem.PatientProviderAddressLine2,
             ediInputItem.PatientProviderAddressCity,
             ediInputItem.PatientProviderAddressState,
             ediInputItem.PatientProviderAddressZip,

             ediInputItem.PatientID,
             ediInputItem.PatientLastName,
             ediInputItem.PatientFirstName,
             ediInputItem.PatientMiddleName,
             ediInputItem.PatientAddressLine1,
             ediInputItem.PatientAddressLine2,
             ediInputItem.PatientAddressCity,
             ediInputItem.PatientAddressState,
             ediInputItem.PatientAddressZip,
             ediInputItem.PatientDOB,
             ediInputItem.PatientGender, out strControler);

            var edi271 = ediUtils.Post270AndGet271(edi270, ediInputItem.RxhubURL, ediInputItem.RxHubAuthorization);
            if (edi271.StartsWith("$Exception$"))
            {
                EDIOutput271 ediOutputItem = new EDIOutput271();
                ediOutputItem.ShowMessage = edi271;
                ediOutputItem.Send270UsingDEA = ediInputItem.Send270UsingDEA;
                return ediOutputItem;
            }
            else
            {
                bool Send270UsingDEA = ediInputItem.Send270UsingDEA;
                EDIOutput271 ediOutputItem = ediUtils.Read271(edi271, ref Send270UsingDEA);
                return ediOutputItem;
            }


        }
        [HttpPost]
        [ActionName("GetEligibility")]
        public CreatedAtActionResult Post270AndGet271(EDIInput ediInputItem)
        {
            EDIOutput271 ediOutputItem = Send270AndGet271(ediInputItem);
            return CreatedAtAction(nameof(Send270AndGet271), new { id = 1 }, ediOutputItem);
        }
    }
}

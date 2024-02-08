using Api_BotWhatsApp.Api.Model;
using Microsoft.AspNetCore.Mvc;

namespace Api_BotWhatsApp.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WhatsAppController : ControllerBase
    {
        private readonly ILogger<WhatsAppController> _logger;

        public WhatsAppController(ILogger<WhatsAppController> logger)
        {
            _logger = logger;
        }

        [HttpGet("GetMessageAVencer")]
        public JsonResult GetMessageAVencer()
        {
            List<Model.MensagensWhatsApp> list =
            [
                new MensagensWhatsApp("Bruno Lucas", "5519999999999", "Sr. Bruno, o vencimento da sua fatura é 11/12/2023."),
                new MensagensWhatsApp("Flávia Neves", "5519999999999", "Sra. Flávia, o vencimento da sua fatura é 15/12/2023."),
                new MensagensWhatsApp("Diogo Brandão", "5519999999999", "Sr. Diogo, o vencimento da sua fatura é 15/12/2023.")
            ];

            return new JsonResult(list);
        }
    }
}

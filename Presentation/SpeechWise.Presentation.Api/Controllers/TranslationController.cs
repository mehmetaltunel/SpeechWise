using MediatR;
using Microsoft.AspNetCore.Mvc;
using SpeechWise.BusinessLogic.Models.Commands.Request;
using SpeechWise.BusinessLogic.Utilities.BaseClasses;

namespace SpeechWise.Presentation.Api.Controllers
{

    public class TranslationController : BaseController
    {
        public TranslationController(ILogger<BaseController> logger, IMediator mediator) : base(logger, mediator)
        {
        }

        public async Task<IActionResult> Text([FromBody] TextTranslationRequestModel requestModel)
            => Handle(await _mediator.Send(requestModel));
    }
}
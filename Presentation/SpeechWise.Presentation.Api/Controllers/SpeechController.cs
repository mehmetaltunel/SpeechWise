using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SpeechWise.BusinessLogic.Utilities.BaseClasses;

namespace SpeechWise.Presentation.Api.Controllers
{
    public class SpeechController : BaseController
    {
        public SpeechController(ILogger<BaseController> logger, IMediator mediator) : base(logger, mediator)
        {
        }
    }
}

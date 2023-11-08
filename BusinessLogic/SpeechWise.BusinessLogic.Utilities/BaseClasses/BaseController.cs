using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SpeechWise.BusinessLogic.Utilities.ResponseManagement;

namespace SpeechWise.BusinessLogic.Utilities.BaseClasses
{
    [ApiController]
    [Route("[controller]")]
    public abstract class BaseController : ControllerBase
    {
        protected readonly ILogger<BaseController> _logger;
        protected readonly IMediator _mediator;
        public BaseController(ILogger<BaseController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        protected ActionResult Handle<T>(ResponseItem<T> response)
        {
            if (response.Status == "OK")
            {
                var x = Ok(BaseResponseModel.Ok(response, HttpContext.TraceIdentifier));
                return x;
            }
            else
                return BadRequest(BaseResponseModel.BadRequest(ResponseMessageToString.ResponseMessageToStr(response.Messages), HttpContext.TraceIdentifier));
        }
    }
}

using MediatR;
using SpeechWise.BusinessLogic.Models.Commands.Response;
using SpeechWise.BusinessLogic.Utilities.ResponseManagement;

namespace SpeechWise.BusinessLogic.Models.Commands.Request
{
    public class TextTranslationRequestModel : IRequest<ResponseItem<TextTranslationResponseModel>>
    {
        public string Text { get; set; }
    }
}

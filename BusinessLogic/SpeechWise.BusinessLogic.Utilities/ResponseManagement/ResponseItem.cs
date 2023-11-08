﻿using Newtonsoft.Json;

namespace SpeechWise.BusinessLogic.Utilities.ResponseManagement
{
    public class ResponseItem<T>
    {
        public T Data { get; set; }
        public IList<ResponseMessage> Messages { get; set; }
        public string Status { get; set; }
        public int? Count { get; set; }
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }

    public class ResponseItem : ResponseItem<object>
    {
    }
}

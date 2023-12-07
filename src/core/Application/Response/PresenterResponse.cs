using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Response
{
    public  class PresenterResponse
    {
        public List<string> Messages { get; private set; }

        public bool Status { get; private set; }

        public object? Data { get; private set; }

        public PresenterResponse(string message, bool status, object? data)
        {
            Messages = [message];
            Status = status;
            Data = data;
        }

        public PresenterResponse(List<string> messages, bool status)
        {
            Messages = messages;
            Status = status;
        }
    }
}

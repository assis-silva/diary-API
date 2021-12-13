using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Diary.Application.DTOs.Generics
{
    public class Response
    {
        public IList<string> ErrorMessages { get; protected set; } = new List<string>();
        public bool HasErrors { get; protected set; }
        public string Message { get; protected set; }
        public HttpStatusCode StatusCode { get; protected set; }
        public object collections { get; set; }
        public int Count { get; set; }


        public void AddErrorMessages(string message)
        {
            ErrorMessages.Add(message);
            HasErrors = true;
        }

        public Task<Response> GenerateResponse(HttpStatusCode statusCode = HttpStatusCode.OK, bool hasError = default, string message = default, object collection = default, int count = default)
        {
            StatusCode = statusCode;
            HasErrors = hasError;
            Message = message;
            collections = collection;
            Count = count;
            return Task.FromResult(this);
        }

    }
}

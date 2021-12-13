using Diary.Domain.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary.Application.Exceptions
{
    public class PersistanceDbException<T> : Exception
    {
        public T Request { get; set; }
        public string HandlerName { get; set; }
        public PersistanceDbException(T request, string handlerName) : base(Messages.Error)
        {
            Request = request;
            HandlerName = handlerName;
        }
    }
}

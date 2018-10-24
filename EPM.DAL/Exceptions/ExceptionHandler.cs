using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EPM.DAL.Exceptions
{
    [Serializable]
    public class ExceptionHandler : ApplicationException
    {
        public ExceptionHandler()
        { }
        public ExceptionHandler(string message)
            : base(message)
        { }
        public ExceptionHandler(string message, Exception inner)
            : base(message, inner)
        { }
        protected ExceptionHandler(SerializationInfo info, StreamingContext context)
            : base(info, context)
        { }
    }
}

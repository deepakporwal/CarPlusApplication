using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class ClmResponse
    {
        public bool Status { get; set; }
        public string Message { get; set; }
        public string ResponseCode { get; set; }
        public IList<ValidationFailureInfo> ErrorMessages { get; set; }
    }

    public class ValidationFailureInfo 
    {
        public string PropertyName { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class ClmResponse<T> : ClmResponse 
    {
        public T Data { get; set; }
    }
}

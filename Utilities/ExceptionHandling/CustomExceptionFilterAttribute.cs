using Common;
using Microsoft.AspNetCore.Mvc.Filters;
using System;


namespace Utilities
{
    public class CustomExceptionFilterAttribute : ExceptionFilterAttribute
    {
        public CustomExceptionFilterAttribute()
        {

        }

        public override void OnException(ExceptionContext context)
        {
            object[] errorDetails = new object[]
            {
                (context.Exception.TargetSite).Name.ToString(), // Event Name
                context.Exception.Source, // Error Source
                context.Exception.StackTrace, // full Trace
                context.Exception.Message,
                context.HttpContext.Request.QueryString.ToString() // Query string
            };

            var clmResponse = new ClmResponse<string>()
            {
                Data = null,
                Status = false,
                Message = "Error Occured in API"
            };
            context.Result = new ac
        }
    }
}

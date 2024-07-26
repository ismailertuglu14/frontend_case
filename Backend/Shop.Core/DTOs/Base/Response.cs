using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.DTOs.Base
{
    public class Response<T> where T : class
    {
        public T? Data { get; set; }
        public StatusCodes StatusCode { get; set; }
        public string? Message { get; set; }

        public static Response<T> Success(T Data) => new() { Data = Data, StatusCode = StatusCodes.SUCCESS };
        public static Response<T> Success(T Data, StatusCodes statusCode) => new() { Data = Data, StatusCode = statusCode };
        public static Response<T> Fail(StatusCodes statusCode, string message) => new() { Data = default(T), Message = message, StatusCode = statusCode };
    }
}

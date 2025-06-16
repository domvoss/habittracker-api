using HabitTracker.Application.Models.Responses;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace HabitTracker.API.Controllers.Base
{
    [ApiController]
    public class BaseController : Controller
    {
        protected static OkObjectResult Success<T>(T data)
        {
            return new OkObjectResult(new ApiResponse<T>
            {
                Data = data,
                Success = true,
                ErrorCode = HttpStatusCode.OK
            });
        }

        protected static ObjectResult Fail(HttpStatusCode code, string message)
        {
            ApiResponse<string> response = new()
            {
                Data = "",
                Message = message,
                Success = false,
                ErrorCode = code
            };

            return new ObjectResult(response)
            {
                StatusCode = (int)code
            };
        }
    }
}

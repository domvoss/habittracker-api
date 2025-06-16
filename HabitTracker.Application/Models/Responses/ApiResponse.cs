using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HabitTracker.Application.Models.Responses
{
    public class ApiResponse<T>
    {
        public required T Data { get; set; }
        public string? Message { get; set; }
        public required bool Success { get; set; }
        public required HttpStatusCode ErrorCode { get; set; }
    }
}

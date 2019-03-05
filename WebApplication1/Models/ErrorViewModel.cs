using System;

namespace WebApplication1.Models
{
    public class ErrorViewMode
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}

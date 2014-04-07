using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TryingToTimoutAspNetMvcRequests.Models
{
    public class IndexModel
    {
        public TimeSpan ExecutionTime { get; set; }
        public string Content { get; set; }
    }
}
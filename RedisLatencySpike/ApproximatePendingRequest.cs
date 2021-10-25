using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedisLatencySpike
{
    public class ApproximatePendingRequest
    {
        public int PendingRequestCount { get; set; }
        public string FrontEnd { get; set; }
        public string Worker { get; set; }
        public DateTimeOffset Timestamp { get; set; }
    }
}

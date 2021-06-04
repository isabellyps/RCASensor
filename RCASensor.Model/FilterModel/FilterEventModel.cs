using System;

namespace RCASensor.Model.FilterModel
{
    public class FilterEventModel : FilterBase
    {
        public string Country { get; set; }
        public string Region { get; set; }
        public string Sensor { get; set; }
        public StatusEvent StatusEvent { get; set; }
        public DateTime DateTime { get; set; }
    }

    public enum StatusEvent
    {
        ALL = 1,
        SUCCESS = 2,
        ERROR = 3
    }
}

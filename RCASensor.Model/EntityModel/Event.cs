using System;

namespace RCASensor.Model.EntityModel
{
    public class Event
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string Sensor { get; set; }
        public string Value { get; set; }
        public DateTime DateTime { get; set; }
    }
}

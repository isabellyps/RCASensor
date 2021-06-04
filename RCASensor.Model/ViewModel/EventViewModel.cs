using RCASensor.Utils;
using System;

namespace RCASensor.Model.FilterModel
{
    public class EventViewModel
    {
        public long TimeStamp { get; set; }
        public string Tag { get; set; }
        public string Value { get; set; }

        public DateTime Date
        {
            get
            {
                return DateConverter.UnixTimeStampToDateTime(TimeStamp);
            }
        }
    }
}

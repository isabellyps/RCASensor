using RCASensor.Model.EntityModel;
using RCASensor.Model.FilterModel;
using System.Collections.Generic;

namespace RCASensor.Repository
{
    public interface IEventRepository
    {
        void InsertEvent(Event model);
        List<Event> GetEvents(FilterEventModel filter);
        List<string> GetCountries();
        List<string> GetRegions();
        List<string> GetSensors();
        long GetCountEvents();
    }
}

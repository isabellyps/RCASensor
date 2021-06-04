using RCASensor.Model.FilterModel;
using System.Collections.Generic;

namespace RCASensor.Business
{
    public interface IEventBusiness
    {
        void InsertEvent(EventViewModel model);
        List<EventInfoViewModel> GetEvents(FilterEventModel filter);
        List<string> GetCountries();
        List<string> GetRegions();
        List<string> GetSensors();
        long GetCountEvents();
    }
}

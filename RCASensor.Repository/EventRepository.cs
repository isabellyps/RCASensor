using RCASensor.Model.EntityModel;
using RCASensor.Model.FilterModel;
using System.Collections.Generic;
using System.Linq;

namespace RCASensor.Repository
{
    public class EventRepository : IEventRepository
    {
        public void InsertEvent(Event model)
        {
            using (var context = new RCASensorContext())
            {
                context.Add<Event>(model);
                context.SaveChanges();
            }
            
        }

        public List<Event> GetEvents(FilterEventModel filter)
        {
            using (var context = new RCASensorContext())
            {
                var events = context.Event.AsQueryable();

                if (!string.IsNullOrEmpty(filter.Country))
                    events = events.Where(x => x.Country == filter.Country);

                if (!string.IsNullOrEmpty(filter.Region))
                    events = events.Where(x => x.Region == filter.Region);

                if (!string.IsNullOrEmpty(filter.Sensor))
                    events = events.Where(x => x.Sensor == filter.Sensor);

                if (!string.IsNullOrEmpty(filter.Country))
                    events = events.Where(x => x.Country == filter.Country);

                switch (filter.StatusEvent)
                {
                    case StatusEvent.SUCCESS:
                        events = events.Where(x => !string.IsNullOrEmpty(x.Value));
                        break;
                    case StatusEvent.ERROR:
                        events = events.Where(x => string.IsNullOrEmpty(x.Value));
                        break;
                }

                events = filter.Pagination(events);

                return events.ToList();
            }
        }

        public List<string> GetCountries()
        {
            using (var context = new RCASensorContext())
            {
                var countries = context.Event
                    .GroupBy(x => x.Country)
                    .Select(x => x.Key)
                    .ToList();

                return countries;
            }
        }

        public List<string> GetRegions()
        {
            using (var context = new RCASensorContext())
            {
                var regions = context.Event
                    .GroupBy(x => x.Region)
                    .Select(x => x.Key)
                    .ToList();

                return regions;
            }
        }

        public List<string> GetSensors()
        {
            using (var context = new RCASensorContext())
            {
                var sensors = context.Event
                    .GroupBy(x => x.Sensor)
                    .Select(x => x.Key)
                    .ToList();

                return sensors;
            }
        }

        public long GetCountEvents()
        {
            using (var context = new RCASensorContext())
            {
                var countItems = context.Event.Count();

                return countItems;
            }
        }
    }
}

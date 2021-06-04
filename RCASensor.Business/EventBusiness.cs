using RCASensor.Model.EntityModel;
using RCASensor.Model.FilterModel;
using RCASensor.Repository;
using System.Collections.Generic;
using AutoMapper;

namespace RCASensor.Business
{
    public class EventBusiness : IEventBusiness
    {
        private readonly IEventRepository _eventRepository;
        private readonly IMapper _mapper;

        public EventBusiness(IEventRepository eventRepository, IMapper mapper)
        {
            _eventRepository = eventRepository;
            _mapper = mapper;
        }

        public void InsertEvent(EventViewModel model)
        {
            string[] dataTag = model.Tag.Split('.');

            var country = dataTag[0];
            var region = dataTag[1];
            var sensor = dataTag[2];

            var eventBusiness = new Event
            {
                Country = country,
                Region = region,
                Sensor = sensor,
                Value = model.Value,
                DateTime = model.Date
            };

            _eventRepository.InsertEvent(eventBusiness);

        }

        public List<EventInfoViewModel> GetEvents(FilterEventModel filter)
        {
            var events = _eventRepository.GetEvents(filter);

            var eventsModel = _mapper.Map<List<EventInfoViewModel>>(events);

            return eventsModel;
        }

        public List<string> GetCountries()
        {
            var countrys = _eventRepository.GetCountries();

            return countrys;
        }

        public List<string> GetRegions()
        {
            var regions = _eventRepository.GetRegions();

            return regions;
        }
        public List<string> GetSensors()
        {
            var sensors = _eventRepository.GetSensors();

            return sensors;
        }

        public long GetCountEvents()
        {
            var countEvents = _eventRepository.GetCountEvents();

            return countEvents;
        }
    }
}

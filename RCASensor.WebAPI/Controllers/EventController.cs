using Microsoft.AspNetCore.Mvc;
using RCASensor.Business;
using RCASensor.Model.FilterModel;
using System.Collections.Generic;

namespace RCASensor.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private readonly IEventBusiness _eventBusiness;

        public EventController(IEventBusiness eventBusiness)
        {
            _eventBusiness = eventBusiness;
        }

        [HttpPost]
        public void InsertEvent(EventViewModel model)
        {
             _eventBusiness.InsertEvent(model);
        }

        [HttpGet("GetEvents")]
        public List<EventInfoViewModel> GetEvents([FromQuery] FilterEventModel filter)
        {
            var eventsInfo = _eventBusiness.GetEvents(filter);

            return eventsInfo;
        }

        [HttpGet("GetCountries")]
        public List<string> GetCountries()
        {
            var countries = _eventBusiness.GetCountries();

            return countries;
        }

        [HttpGet("GetRegions")]
        public List<string> GetRegions()
        {
            var regions = _eventBusiness.GetRegions();

            return regions;
        }

        [HttpGet("GetSensors")]
        public List<string> GetSensors()
        {
            var sensors = _eventBusiness.GetSensors();

            return sensors;
        }

        [HttpGet("GetCountEvents")]
        public long GetCountEvents()
        {
            var countEvents = _eventBusiness.GetCountEvents();

            return countEvents;
        }
    }
}

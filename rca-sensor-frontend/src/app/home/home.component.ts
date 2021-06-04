import { Component, Inject, OnInit } from '@angular/core';

import { faCheck, faTimes } from '@fortawesome/free-solid-svg-icons'

import { FilterEvent, EventInfo } from '../service/events.model';
import { EventsService } from '../service/events.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {

  faCheck = faCheck;
  faTimes = faTimes;

  public events: Array<EventInfo> = new Array();
  public countries: any;
  public regions: any;
  public sensors: any;
  public amount: any;
  public count: number = 10;
  public pageCurrent: number = 1;
  public statusEvent = [
    { status: 'Todos', id: 1 },
    { status: 'Processados', id: 2 },
    { status: 'Com erro', id: 3 },
  ]
  public filters: FilterEvent = {
    Country: '',
    Region: '',
    Sensor: '',
    StatusEvent: 1,
    Page: 1,
    AmountItemsShow: 10
  };

  constructor(
    @Inject(EventsService) private eventsService: EventsService
  ) { }

  ngOnInit(): void {
    this.getPage(1);

    this.eventsService.GetCountries()
      .subscribe((countries) => {
        this.countries = countries;
      });

    this.eventsService.GetRegions()
      .subscribe((regions) => {
        this.regions = regions;
      });

    this.eventsService.GetSensors()
      .subscribe((sensors) => {
        this.sensors = sensors;
      });

    this.eventsService.GetCountEvents()
      .subscribe((amount) => {
        this.amount = amount;
      });
  }

  getEvents() {
    this.eventsService.GetEvents(this.filters)
      .subscribe((events: EventInfo[]) => {
        this.events = events;
      });
  }

  getPage(page: number) {
    this.filters.Page = page;
    this.getEvents();
  }

  filter() {
    this.getPage(1);
  }
}

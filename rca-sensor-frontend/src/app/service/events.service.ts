import { Inject, Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';

import { environment } from 'src/environments/environment';
import { FilterEvent, EventInfo } from './events.model';

@Injectable({
  providedIn: 'root'
})
export class EventsService {
  readonly apiUrl: string;

  constructor(
    @Inject(HttpClient) private http: HttpClient
  ) {
    this.apiUrl = environment.apiSettings.baseUrl + '/Event';
  }

  GetEvents(obj: FilterEvent) {
    let params = new HttpParams();
    params = params.append('Country', obj.Country);
    params = params.append('Region', obj.Region);
    params = params.append('Sensor', obj.Sensor);
    params = params.append('StatusEvent', obj.StatusEvent);
    params = params.append('Page', obj.Page);
    params = params.append('AmountItemsShow', obj.AmountItemsShow)

    return this.http.get<EventInfo[]>
      (`${this.apiUrl}/GetEvents`, { params: params });
  }

  GetCountries() {
    return this.http.get(`${this.apiUrl}/GetCountries`);
  }

  GetRegions() {
    return this.http.get(`${this.apiUrl}/GetRegions`);
  }

  GetSensors() {
    return this.http.get(`${this.apiUrl}/GetSensors`);
  }

  GetCountEvents() {
    return this.http.get(`${this.apiUrl}/GetCountEvents`);
  }

}

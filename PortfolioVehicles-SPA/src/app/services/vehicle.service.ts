import { Base } from './../models/Base';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Make } from '../models/Make';

@Injectable({
  providedIn: 'root'
})
export class VehicleService {
  baseUrl = environment.apiUrl;

  constructor(private http: HttpClient) { }

  getMakes() {
    return this.http.get<Make[]>(this.baseUrl + 'makes');
  }

  getFeatures() {
    return this.http.get<Base[]>(this.baseUrl + 'features');
  }
}

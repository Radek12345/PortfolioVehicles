import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class VehicleService {
  baseUrl = environment.apiUrl;

  constructor(private http: HttpClient) { }

  getMakes() {
    return this.http.get(this.baseUrl + 'makes');
  }
}

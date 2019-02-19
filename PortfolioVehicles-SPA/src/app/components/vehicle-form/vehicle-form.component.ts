import { Make } from './../../models/Make';
import { VehicleService } from './../../services/vehicle.service';
import { Component, OnInit } from '@angular/core';
import { Base } from 'src/app/models/Base';
import { Vehicle } from 'src/app/models/Vehicle';

@Component({
  selector: 'app-vehicle-form',
  templateUrl: './vehicle-form.component.html',
  styleUrls: ['./vehicle-form.component.css']
})
export class VehicleFormComponent implements OnInit {
  vehicle: Vehicle = {};

  makes: Make[];
  models: Base[];
  features: Base[];

  constructor(private vehicleService: VehicleService) { }

  ngOnInit() {
    this.loadMakes();
    this.loadFeatures();
  }

  loadMakes() {
    this.vehicleService.getMakes().subscribe(makes => {
      this.makes = makes;
    });
  }

  loadModels() {
    // tslint:disable-next-line:triple-equals
    this.models = this.makes.find(m => m.id == this.vehicle.makeId).models;
  }

  loadFeatures() {
    this.vehicleService.getFeatures().subscribe(features => {
      this.features = features;
    });
  }

}

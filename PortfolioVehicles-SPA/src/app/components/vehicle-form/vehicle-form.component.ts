import { VehicleService } from './../../services/vehicle.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-vehicle-form',
  templateUrl: './vehicle-form.component.html',
  styleUrls: ['./vehicle-form.component.css']
})
export class VehicleFormComponent implements OnInit {
  makes: any;

  constructor(private vehicleService: VehicleService) { }

  ngOnInit() {
    this.loadMakes();
  }

  loadMakes() {
    this.vehicleService.getMakes().subscribe(makes => {
      this.makes = makes;
    });
  }

}

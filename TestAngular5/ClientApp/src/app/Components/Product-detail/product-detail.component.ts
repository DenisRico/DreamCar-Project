import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { CarService } from '../../Services/Car/car.service';
import { Car } from '../../Models/car';

@Component({
  templateUrl: './product-detail.component.html',
  providers: [CarService]
})
export class ProductDetailComponent implements OnInit {

  id: number;
  car: Car;
  loaded: boolean = false;

  constructor(
    private carService: CarService,
    activeRoute: ActivatedRoute
  ) {
    this.id = Number.parseInt(activeRoute.snapshot.params["id"]);
  }

  ngOnInit() {
    if (this.id)
      this.carService.getCar(this.id)
        .subscribe((data: Car) => { this.car = data; this.loaded = true; });
  }
}

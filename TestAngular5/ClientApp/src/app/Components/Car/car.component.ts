import { Component, OnInit, ElementRef, ViewChild } from '@angular/core';
import { Car } from '../../Models/car';
import { CarService } from '../../Services/Car/car.service';




/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

@Component({
  selector: 'car',
  templateUrl: './car.component.html',
  styleUrls: ['./car.component.scss'],
})
export class CarComponent implements OnInit {

  displayedColumn: string[] = ['id', 'name', 'year', 'condition', 'fuelType', 'color', 'price', 'actions'];


 
  cars: Car[];                 // массив товаров
  car: Car = new Car();   // изменяемый товар
  tableMode: boolean = true;          // табличный режим
  

  constructor(
    private carService: CarService
  ) { }



  ngOnInit() {
    this.loadProducts();
  }

  loadProducts() {
    this.carService.getCars().subscribe((car: Car[]) => this.cars = car);
     
  }

  delete(id: number) {
    this.carService.deleteCar(id).subscribe(data => this.loadProducts());
  }



  


}




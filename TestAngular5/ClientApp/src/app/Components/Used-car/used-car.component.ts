import { Component, OnInit} from '@angular/core';
import { Car } from '../../Models/car';
import { CarService } from '../../Services/Car/car.service';






@Component({
  selector: 'used-car',
  templateUrl: './used-car.component.html',
  styleUrls: ['./used-car.component.scss'],
})
export class UsedCarComponent implements OnInit {

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
    this.carService.getCars().subscribe((data: Car[]) => this.cars = data);
  }

  add() {
    this.cancel();
    this.tableMode = false;
  }

  delete(car: Car) {
    this.carService.deleteCar(car.id).subscribe(data => this.loadProducts());
  }

  ///Edit of product funktion
  editCar(car: Car) {
    this.car = car;
  }
  
  // сохранение данных
  save() {
    if (this.car.id == null) {
      console.log(this.car);
      this.carService.createCar(this.car)
        .subscribe((data: Car) => this.cars.push(data));
    } else {
      this.carService.updateCar(this.car)
        .subscribe(data => this.loadProducts());
    }
    this.cancel();
    
  }

  cancel() {
    this.car = new Car();
    this.tableMode = true;
    
  }
  


}




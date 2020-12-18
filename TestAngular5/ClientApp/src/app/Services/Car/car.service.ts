import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Car } from '../../Models/car';

 
@Injectable()
export class CarService {
  data = new Car();

 
    private url = "/api/cars";
 
    constructor(private http: HttpClient) {
    }
 
    getCars() {
        return this.http.get(this.url);
    }
     
    getCar(id: number) {
        return this.http.get(this.url + '/' + id);
    }
     
    createCar(car: Car)  {
        return this.http.post(this.url, car);
    }
    updateCar(car: Car) {
  
        return this.http.put(this.url, car);
    }
    deleteCar(id: number) {
        return this.http.delete(this.url + '/' + id);
    }
}

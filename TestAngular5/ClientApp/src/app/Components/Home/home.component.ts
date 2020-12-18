import { Component, OnInit } from '@angular/core';
import { DataService } from '../../Services/Person/data.service';
import { CarService } from '../../Services/Car/car.service';
import { Car } from '../../Models/car';
import { Person } from '../../Models/Staff';



@Component({
  selector: 'home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss'],
  
})
export class HomeComponent implements OnInit {




  persons: Person[];    // array of persons 

  cars: Car[];                 // array of products
  car: Car = new Car();   // product for change
  tableMode: boolean = true;          // table

  constructor(
    private carService: CarService,
    private dataService: DataService
  ) { }

  ngOnInit() {
    this.loadElements();
  }


  loadElements() {
    this.carService.getCars().subscribe((car: Car[]) => this.cars = car);
    this.dataService.getPersons().subscribe((person: Person[]) => this.persons = person);
  }


}

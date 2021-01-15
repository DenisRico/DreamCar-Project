import { Component, OnInit } from '@angular/core';
import { DataService } from '../../Services/Person/data.service';
import { CarService } from '../../Services/Car/car.service';
import { Car } from '../../Models/car';
import { IPerson } from '../../Models/Staff';
import { tap, finalize, takeUntil } from 'rxjs/operators';
import { ReplaySubject, Subscription } from 'rxjs';



@Component({
  selector: 'home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss'],
  
})
export class HomeComponent implements OnInit {


  ///////////////////////////////////////////////////////////////////////////////

  //persons: Person[];    // array of persons 

  private subscriptions = new ReplaySubject<any>(1);

  cars: Car[];                 // array of products
  car: Car = new Car();   // product for change
  tableMode: boolean = true;          // table

  persons = new Array<IPerson>();
  subscr = new Array<Subscription>();


  constructor(
    private carService: CarService,
    private dataService: DataService
  ) { }

  ngOnInit() {
    this.loadElements();

    let subscription = this.dataService.getPersons().pipe(
      takeUntil(this.subscriptions),
      tap((person) => {
        this.persons = person;
      })
    ).subscribe();

    this.subscr.push(subscription);
  }


  loadElements() {
    this.carService.getCars().subscribe((car: Car[]) => this.cars = car);
  }


  ngOnDestroy(): void {
    this.subscriptions.next(null);
    this.subscriptions.complete();

    this.subscr.forEach(subsc => {
      if (subsc) {
        subsc.unsubscribe();
      }
    })
  }

}

import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { IPerson } from '../../Models/Staff';

 
@Injectable()
export class DataService {
 
    private url = "/api/persons";
 
    constructor(private http: HttpClient) {
    }
 
    getPersons() : Observable<any> {
        return this.http.get<IPerson>(this.url);
    }
     
  /////////////////////////////////////////////////////////////////////
}

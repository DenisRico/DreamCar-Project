import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

 
@Injectable()
export class DataService {
 
    private url = "/api/persons";
 
    constructor(private http: HttpClient) {
    }
 
    getPersons() {
        return this.http.get(this.url);
    }
     
  
}

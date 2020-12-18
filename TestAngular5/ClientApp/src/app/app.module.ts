import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule, ReactiveFormsModule} from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule, Routes } from '@angular/router';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { MaterialModule } from '../../src/app/Modules/Angular-material/material-module';


import { CarService } from '../app/Services/Car/car.service';
import { DataService } from '../app/Services/Person/data.service';


import { AppComponent } from './app.component';
import { HomeComponent } from '../app/Components/Home/home.component';
import { ProductDetailComponent } from '../app/Components/Product-detail/product-detail.component';
import { TopBarComponent } from '../app/Components/Top-bar/top-bar.component';
import { FooterComponent } from '../app/Components/Footer/footer.component';
import { CarComponent } from '../app/Components/Car/car.component';
import { UsedCarComponent } from '../app/Components/Used-car/used-car.component';




// определение маршрутов
const appRoutes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'product/:id', component: ProductDetailComponent },
  { path: 'top-bar', component: TopBarComponent },
  { path: 'car', component: CarComponent },
  { path: 'used-car', component: UsedCarComponent },
  { path: '**', redirectTo: '/' }
];

@NgModule({
  imports: [BrowserModule,
    FormsModule,
    HttpClientModule,
    RouterModule.forRoot(appRoutes),
    BrowserAnimationsModule,
    MaterialModule

  ],
  declarations: [
    AppComponent,
    HomeComponent,
    ProductDetailComponent,
    TopBarComponent,
    FooterComponent,
    CarComponent,
    UsedCarComponent

  ],
  bootstrap: [AppComponent],
  providers: [
    CarService,
    DataService
  ]
})
export class AppModule { }

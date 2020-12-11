import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule, ReactiveFormsModule} from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule, Routes } from '@angular/router';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { MatSliderModule } from '@angular/material/slider';
import { MatCardModule } from '@angular/material/card';
import { MatMenuModule } from '@angular/material/menu';
import { MatGridListModule } from '@angular/material/grid-list';
import { MatTabsModule } from '@angular/material/tabs';
import { MatTableModule } from '@angular/material/table';
import { MatInputModule } from '@angular/material/input';
import { MatButtonModule } from '@angular/material/button';
import { MatDialogModule } from '@angular/material/dialog';
import { MatIconModule } from '@angular/material/icon';
import { MatPaginatorModule } from '@angular/material/paginator';
import { MatSortModule } from '@angular/material/sort';
import { MatToolbarModule } from '@angular/material/toolbar';

import { DataService } from '../app/Services/Product/data.service';
import { CarService } from '../app/Services/Car/car.service';


import { AppComponent } from './app.component';
import { ProductComponent } from '../app/Components/Product/product.component';
import { ProductListComponent } from '../app/Components/product-list/product-list.component';
import { ProductDetailComponent } from '../app/Components/Product-detail/product-detail.component';
import { PageComponent } from '../app/Components/Page/page.component';
import { ProductAngularComponent } from '../app/Components/ProductAngular/product-angular.component';
import { TopBarComponent } from '../app/Components/Top-bar/top-bar.component';
import { SongComponent } from '../app/Components/Song/song-list.component';
import { FooterComponent } from '../app/Components/Footer/footer.component';
import { CarComponent } from '../app/Components/Car/car.component';
import { UsedCarComponent } from '../app/Components/Used-car/used-car.component';




// определение маршрутов
const appRoutes: Routes = [
  { path: '', component: ProductListComponent },
  { path: 'product/:id', component: ProductDetailComponent },
  { path: 'page', component: PageComponent },
  { path: 'product-angular', component: ProductAngularComponent },
  { path: 'top-bar', component: TopBarComponent },
  { path: 'song', component: SongComponent },
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
    MatSliderModule,
    MatCardModule,
    MatMenuModule,
    MatGridListModule,
    MatTabsModule,
    MatTableModule,
    MatInputModule,
    MatButtonModule,
    MatDialogModule,
    MatIconModule,
    MatPaginatorModule,
    MatSortModule,
    MatToolbarModule

  ],
  declarations: [
    AppComponent,
    ProductComponent,
    ProductListComponent,
    ProductDetailComponent,
    PageComponent,
    ProductAngularComponent,
    TopBarComponent,
    SongComponent,
    FooterComponent,
    CarComponent,
    UsedCarComponent

  ],
  bootstrap: [AppComponent],
  providers: [
    DataService,
    CarService
  ]
})
export class AppModule { }

import { NgModule } from '@angular/core';

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

@NgModule({
  exports: [MatSliderModule,
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
  ]
})
export class MaterialModule { }

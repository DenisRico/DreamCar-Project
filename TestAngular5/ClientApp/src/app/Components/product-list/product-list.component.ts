import { Component, OnInit } from '@angular/core';
import { DataService } from '../../Services/Product/data.service';
import { Product } from '../../Models/product';

export interface Tile {
  color: string;
  cols: number;
  rows: number;
  text: string;
  border: string;
  margin: string;
}

@Component({
  selector: 'product-list',
  templateUrl: './product-list.component.html',
  styleUrls: ['./product-list.component.scss'],
  
})
export class ProductListComponent implements OnInit {

  tiles: Tile[] = [
    { text: 'https://i.pcmag.com/imagery/reviews/03xdTO0Ka4H4KvEgtSPg4c2-12.1569479325.fit_lpad.size_625x365.jpg', cols: 2, rows: 2, color: 'lightblue', border: '3px double #08F8DB',margin:'10px' },
    {
      text: 'https://media.wired.com/photos/5d09594a62bcb0c9752779d9/1:1/w_1500,h_1500,c_limit/Transpo_G70_TA-518126.jpg', cols: 2, rows: 2, color: 'lightgreen', border: '3px double #08F8DB',margin: '10px' },
    { text: 'https://img.etimg.com/thumb/msid-73268134,width-640,resizemode-4,imgsize-35417/surprise-heard-of-a-sony-car.jpg', cols: 2, rows: 2, color: 'lightpink', border: '3px double #08F8DB', margin: '10px' },
    { text: 'https://cars.usnews.com/pics/size/640x420/static/images/article/202006/128503/216702_New_Volvo_XC40_-_exterior_640x420.jpg', cols: 2, rows: 2, color: '#DDBDF1', border: '3px double #08F8DB', margin: '10px' },
    { text: 'https://www.autocar.co.uk/sites/autocar.co.uk/files/images/car-reviews/first-drives/legacy/large-2479-s-classsaloon.jpg', cols: 2, rows: 2, color: '#DDBDF1', border: '3px double #08F8DB', margin: '10px' },
    { text: 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR126Egai2fY4FkiQXxaTl0Y628xFAygzbI6g&usqp=CAU', cols: 2, rows: 2, color: '#DDBDF1', border: '3px double #08F8DB', margin: '10px' },
  ];

  products: Product[];                 // массив товаров
  product: Product = new Product();   // изменяемый товар
  tableMode: boolean = true;          // табличный режим
  constructor(private dataService: DataService) { }

  ngOnInit() {
    this.loadProducts();
  }

  ///Load Products function
  loadProducts() {
    this.dataService.getProducts().subscribe((data: Product[]) => this.products = data);
  }

  add() {
    this.cancel();
    this.tableMode = false;
  }

  delete(product: Product) {
    this.dataService.deleteProduct(product.id).subscribe(data => this.loadProducts());
  }
  ///Edit of product funktion
  editProduct(p: Product) {
    this.product = p;
  }

  // сохранение данных
  save() {
    if (this.product.id == null) {
      this.dataService.createProduct(this.product)
        .subscribe((data: Product) => this.products.push(data));
    } else {
      this.dataService.updateProduct(this.product)
        .subscribe(data => this.loadProducts());
    }
    this.cancel();
  }

  cancel() {
    this.product = new Product();
    this.tableMode = true;
  }

}

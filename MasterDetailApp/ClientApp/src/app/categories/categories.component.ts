import { Component, Inject, OnInit } from '@angular/core';
import { HttpClient, HttpParams, HttpHeaders } from '@angular/common/http';
import { CategoryService } from '../services/category.service';

@Component({
  selector: 'categories',
  templateUrl: './categories.component.html',
  styleUrls: ['./categories.component.css']
})
export class CategoriesComponent implements OnInit {

  public categories: Category[];

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string, private categoryService: CategoryService) {
  }

  delete(category) {
    const options = {
      headers: new HttpHeaders({
        'Content-Type': 'application/json'
      }),
      body: {
        id: category.id
      }
    };

    this.http.delete(this.baseUrl + 'api/Category', options).subscribe(result => {
      this.getCategories();
    }, error => alert(`Error occurred deleting article ${ category.id }`));
  }

  ngOnInit(): void {
    this.getCategories();
  }

  getCategories() {
    this.categoryService.getCategories().subscribe(categories => {
      this.categories = categories;
    }, error => console.log(error));
  }
}

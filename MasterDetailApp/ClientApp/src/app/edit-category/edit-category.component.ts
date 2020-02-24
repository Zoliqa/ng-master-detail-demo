import { Location } from '@angular/common';
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { Component, Inject, OnDestroy, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { Subscription } from 'rxjs';
import { NgForm } from '@angular/forms';
import { Category } from '../category';

@Component({
  selector: 'edit-category',
  templateUrl: './edit-category.component.html',
  styleUrls: ['./edit-category.component.css']
})
export class EditCategoryComponent implements OnInit, OnDestroy {

  public isValidated: boolean = false;
  public category: Category;
  private sub: Subscription;

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string, private router: Router, private route: ActivatedRoute, private location: Location) {
  }

  ngOnInit() {
    this.sub = this.route.params.subscribe(params => {
      let id = +params['id'];

      if (id !== 0) {
        this.getCategory(id);
      }
      else {
        this.category = {
          id: 0
        } as Category;
      }
    });
  }

  getCategory(id: number) {
    var params = new HttpParams()
      .set('id', id.toString());

    this.http.get<Category>(this.baseUrl + 'api/Category/GetCategory', { params: params }).subscribe(category => {
      this.category = category;
    }, error => console.error(error));
  }

  onSubmit(form: NgForm) {
    this.isValidated = true;

    if (form.invalid) {
      return;
    }

    const options = {
      headers: new HttpHeaders({
        'Content-Type': 'application/json'
      })
    };

    if (this.category.id === 0) {
      this.http.put(this.baseUrl + 'api/Category', this.category, options).subscribe(article => {
        this.router.navigate(['/categories']);
      }, error => console.error(error));
    }
    else {
      this.http.post(this.baseUrl + 'api/Category', this.category, options).subscribe(article => {
        this.router.navigate(['/categories'])
      }, error => console.error(error));
    }
  }

  cancel() {
    this.location.back();
  }

  ngOnDestroy(): void {
    this.sub.unsubscribe();
  }
}



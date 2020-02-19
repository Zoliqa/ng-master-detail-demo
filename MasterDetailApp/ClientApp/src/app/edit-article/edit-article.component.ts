import { Component, Inject, OnInit, OnDestroy } from '@angular/core';
import { HttpClient, HttpParams, HttpHeaders } from '@angular/common/http';
import { Article } from '../article';
import { ActivatedRoute, Router } from '@angular/router';
import { Subscription } from 'rxjs';
import { Location } from '@angular/common';
import { CategoryService } from '../services/category.service';

@Component({
  selector: 'edit-article',
  templateUrl: './edit-article.component.html',
  styleUrls: ['./edit-article.component.css'],
  providers: [CategoryService]
})
export class EditArticleComponent implements OnInit, OnDestroy {

  public article: Article;
  public categories: Category[];
  private sub: Subscription;

  constructor(private route: ActivatedRoute, private http: HttpClient, @Inject('BASE_URL') private baseUrl: string, private router: Router, private location: Location, private categoryService: CategoryService) {
  }

  ngOnInit() {
    this.categoryService.getCategories().subscribe(categories => {
      this.categories = categories
    }, error => console.log(error));

    this.sub = this.route.params.subscribe(params => {
      let id = +params['id'];

      if (id !== 0) {
        this.getArticle(id);
      }
      else {
        this.article = {
          id: 0
        } as Article;
      }
    });
  }

  getArticle(id: number) {
    var params = new HttpParams()
      .set('id', id.toString());

    this.http.get<Article>(this.baseUrl + 'api/Article/GetArticle', { params: params }).subscribe(article => {
      this.article = article;
    }, error => console.error(error));
  }

  save() {
    const options = {
      headers: new HttpHeaders({
        'Content-Type': 'application/json'
      })
    };

    if (this.article.id === 0) {
      this.http.put(this.baseUrl + 'api/Article', this.article, options).subscribe(article => {
        this.router.navigate([''], { queryParams: { searchTerm: this.article.title } });
      }, error => console.error(error));
    }
    else {
      this.http.post(this.baseUrl + 'api/Article', this.article, options).subscribe(article => {
        this.location.back();
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



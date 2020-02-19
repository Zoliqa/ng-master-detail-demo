import { Component, Inject, OnInit, OnDestroy } from '@angular/core';
import { HttpClient, HttpParams, HttpHeaders } from '@angular/common/http';
import { Article } from '../article';
import { ActivatedRoute, Router } from '@angular/router';
import { Subscription } from 'rxjs';
import { Location } from '@angular/common';

@Component({
  selector: 'edit-article',
  templateUrl: './edit-article.component.html',
  styleUrls: ['./edit-article.component.css']
})
export class EditArticleComponent implements OnInit, OnDestroy {
  article: Article;
  categories: Category[];
  private sub: Subscription;

  constructor(private route: ActivatedRoute, private http: HttpClient, @Inject('BASE_URL') private baseUrl: string, private router: Router, private location: Location) {
    this.http.get<Category[]>(this.baseUrl + 'api/Category/List').subscribe(categories => {
      this.categories = categories;
    }, error => console.error(error));
  }

  ngOnInit() {
    this.sub = this.route.params.subscribe(params => {
      let id = <number>params['id'];

      this.getArticle(id);
    });
  }

  getArticle(id: number) {
    var params = new HttpParams()
      .set('id', id.toString());

    this.http.get<Article>(this.baseUrl + 'api/Articles/GetArticle', { params: params }).subscribe(article => {
      this.article = article;
    }, error => console.error(error));
  }

  save() {
    const options = {
      headers: new HttpHeaders({
        'Content-Type': 'application/json'
      })
    };

    this.http.post(this.baseUrl + 'api/Articles', this.article, options).subscribe(article => {
      //this.router.navigate(['']);
      this.location.back();
    }, error => console.error(error));
  }

  ngOnDestroy(): void {
    this.sub.unsubscribe();
  }
}

interface Category {
  id: number;
  name: string;
}

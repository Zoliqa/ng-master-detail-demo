import { Component, Inject } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { Article } from '../article';
import { ListArticles } from '../list-articles';

@Component({
  selector: 'articles',
  templateUrl: './articles.component.html',
  styleUrls: ['./articles.component.css']
})
export class ArticlesComponent {
  public articles: Article[];
  public numberOfPages: number[];
  public selectedPage: number = 1;

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {
    this.getArticles();
  }

  onPageChange(page) {
    this.selectedPage = page;

    this.getArticles();
  }

  getArticles() {
    var params = new HttpParams().set('pageNumber', this.selectedPage.toString());

    this.http.get<ListArticles>(this.baseUrl + 'api/Articles/List', { params: params }).subscribe(result => {
      this.articles = result.articles;
      this.numberOfPages = Array.from(Array(result.numberOfPages).keys()).map(x => x + 1);
    }, error => console.error(error));
  }
}

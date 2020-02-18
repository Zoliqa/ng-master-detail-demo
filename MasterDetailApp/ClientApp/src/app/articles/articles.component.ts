import { Component, Inject } from '@angular/core';
import { HttpClient, HttpParams, HttpHeaders } from '@angular/common/http';
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
  public searchTerm: string = '';

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {
    this.getArticles();
  }

  onPageChange(page) {
    this.selectedPage = page;

    this.getArticles();
  }

  getArticles() {
    var params = new HttpParams()
      .set('pageNumber', this.selectedPage.toString())
      .set('searchTerm', this.searchTerm);

    this.http.get<ListArticles>(this.baseUrl + 'api/Articles', { params: params }).subscribe(result => {
      this.articles = result.articles;
      this.numberOfPages = Array.from(Array(result.numberOfPages).keys()).map(x => x + 1);
    }, error => console.error(error));
  }

  selectPreviousPage() {
    if (this.selectedPage > 1) {
      this.selectedPage--;

      this.getArticles();
    }
  }

  selectNextPage() {
    if (this.selectedPage < this.numberOfPages.slice(-1)[0]) {
      this.selectedPage++;

      this.getArticles();
    }
  }

  onSearchTermChange() {
    console.log(this.searchTerm);

    this.selectedPage = 1;

    this.getArticles();
  }

  edit(article) {
    console.log('edit');
  }

  delete(article) {
    const options = {
      headers: new HttpHeaders({
        'Content-Type': 'application/json'
      }),
      body: {
        id: article.id
      }
    };

    this.http.delete(this.baseUrl + 'api/Articles', options).subscribe(result => {
      this.getArticles();
    }, error => console.error(error));
  }
}

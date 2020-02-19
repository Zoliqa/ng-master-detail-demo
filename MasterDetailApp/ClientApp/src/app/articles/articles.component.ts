import { Component, Inject, OnInit } from '@angular/core';
import { HttpClient, HttpParams, HttpHeaders } from '@angular/common/http';
import { Article } from '../article';
import { ListArticles } from '../list-articles';
import { Router, ActivatedRoute } from '@angular/router';

@Component({
  selector: 'articles',
  templateUrl: './articles.component.html',
  styleUrls: ['./articles.component.css']
})
export class ArticlesComponent implements OnInit {
    
  public articles: Article[];
  public numberOfPages: number[];
  public selectedPage: number = 1;
  public searchTerm: string = '';

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string, private router: Router, private route: ActivatedRoute) {
  }

  ngOnInit(): void {
    let page = this.route.snapshot.queryParams['page'];

    if (page) {
      this.selectedPage = +page;
    }

    this.getArticles();
  }

  onPageChange(page) {
    this.selectedPage = page;
    this.updatePageQueryString();

    this.getArticles();
  }

  getArticles() {
    var params = new HttpParams()
      .set('pageNumber', this.selectedPage.toString())
      .set('searchTerm', this.searchTerm);

    this.http.get<ListArticles>(this.baseUrl + 'api/Articles/List', { params: params }).subscribe(result => {
      this.articles = result.articles;
      this.numberOfPages = Array.from(Array(result.numberOfPages).keys()).map(x => x + 1);

      if (this.selectedPage > this.numberOfPages.length) {
        this.selectedPage--;
        this.updatePageQueryString();

        this.getArticles();
      }
    }, error => console.error(error));
  }

  selectPreviousPage() {
    if (this.selectedPage > 1) {
      this.selectedPage--;
      this.updatePageQueryString();

      this.getArticles();
    }
  }

  selectNextPage() {
    if (this.selectedPage < this.numberOfPages.slice(-1)[0]) {
      this.selectedPage++;
      this.updatePageQueryString();
      
      this.getArticles();
    }
  }

  private updatePageQueryString() {
    const urlTree = this.router.createUrlTree([], {
      queryParams: { page: this.selectedPage },
      queryParamsHandling: "merge",
      preserveFragment: true
    });

    this.router.navigateByUrl(urlTree);
  }

  onSearchTermChange() {
    console.log(this.searchTerm);

    this.selectedPage = 1;
    this.updatePageQueryString();

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
    }, error => alert(`Error occurred deleting article ${ article.id }`));
  }
}

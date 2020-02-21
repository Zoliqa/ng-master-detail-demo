import { Component, Inject, OnInit } from '@angular/core';
import { HttpClient, HttpParams, HttpHeaders } from '@angular/common/http';
import { Article } from '../article';
import { Category } from '../category';
import { ListArticles } from '../list-articles';
import { Router, ActivatedRoute } from '@angular/router';
import { CategoryService } from '../services/category.service';

@Component({
  selector: 'articles',
  templateUrl: './articles.component.html',
  styleUrls: ['./articles.component.css']
})
export class ArticlesComponent implements OnInit {

  public categories: { [id: string]: Category } = {};
  public articles: Article[];
  public numberOfPages: number[];
  public selectedPage: number = 1;
  public searchTerm: string = '';

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string, private router: Router, private route: ActivatedRoute, private categoryService: CategoryService) {
  }

  ngOnInit(): void {
    let page = this.route.snapshot.queryParams['page'];
    let searchTerm = this.route.snapshot.queryParams['searchTerm'];

    if (page) {
      this.selectedPage = +page;
    }

    if (searchTerm) {
      this.searchTerm = searchTerm;
    }

    this.categoryService.getCategories().subscribe(categories => {
      for (let category of categories) {
        this.categories[category.id] = category;
      }

      this.getArticles();
    }, error => console.log(error));
  }

  onPageChange(page) {
    this.selectedPage = page;
    this.updateQueryString();

    this.getArticles();
  }

  getArticles() {
    var params = new HttpParams()
      .set('pageNumber', this.selectedPage.toString())
      .set('searchTerm', this.searchTerm);

    this.http.get<ListArticles>(this.baseUrl + 'api/Article/List', { params: params }).subscribe(result => {
      this.articles = result.articles;
      this.numberOfPages = Array.from(Array(result.numberOfPages).keys()).map(x => x + 1);

      if (this.selectedPage > this.numberOfPages.length) {
        this.selectedPage--;
        this.updateQueryString();

        this.getArticles();
      }
    }, error => console.error(error));
  }

  selectPreviousPage() {
    if (this.selectedPage > 1) {
      this.selectedPage--;
      this.updateQueryString();

      this.getArticles();
    }

    return false;
  }

  selectNextPage() {
    if (this.selectedPage < this.numberOfPages.slice(-1)[0]) {
      this.selectedPage++;
      this.updateQueryString();
      
      this.getArticles();
    }

    return false;
  }

  private updateQueryString() {
    const urlTree = this.router.createUrlTree([], {
      queryParams: { page: this.selectedPage, searchTerm: this.searchTerm },
      queryParamsHandling: "merge",
      preserveFragment: true
    });

    this.router.navigateByUrl(urlTree);
  }

  onSearchTermChange() {
    this.updateQueryString();

    this.selectedPage = 1;
    this.updateQueryString();

    this.getArticles();
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

    this.http.delete(this.baseUrl + 'api/Article', options).subscribe(result => {
      this.getArticles();
    }, error => alert(`Error occurred deleting article ${article.id}`));

    return false;
  }
}

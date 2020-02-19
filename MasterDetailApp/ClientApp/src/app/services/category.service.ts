import { Injectable, Inject } from "@angular/core";
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class CategoryService {
  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {
  }

  getCategories() {
    return this.http.get<Category[]>(this.baseUrl + 'api/Category/List');
  }
}

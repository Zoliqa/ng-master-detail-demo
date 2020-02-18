import { Component, Inject, OnInit, OnDestroy } from '@angular/core';
import { HttpClient, HttpParams, HttpHeaders } from '@angular/common/http';
import { Article } from '../article';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'edit-article',
  templateUrl: './edit-article.component.html',
  styleUrls: ['./edit-article.component.css']
})
export class EditArticleComponent implements OnInit, OnDestroy {
  id: number;
  private sub: any;

  constructor(private route: ActivatedRoute) {
  }

  ngOnInit() {
    this.sub = this.route.params.subscribe(params => {
      this.id = params['id'];
    });
  }

  ngOnDestroy(): void {
    this.sub.unsubscribe();
  }
}

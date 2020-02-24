import { APP_BASE_HREF } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { FormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { Observable, of } from 'rxjs';
import { CategoryService } from '../services/category.service';
import { ArticlesComponent } from './articles.component';
import { Category } from '../category';
import { HttpClientTestingModule, HttpTestingController } from '@angular/common/http/testing';
import { ListArticles } from '../list-articles';

describe('ArticlesComponent', () => {
  let component: ArticlesComponent;
  let fixture: ComponentFixture<ArticlesComponent>;
  let categoryServiceSpy: jasmine.SpyObj<CategoryService>;
  let httpMock: HttpTestingController;
  const baseUrl = 'base';

  beforeEach(async(() => {
    const spy = jasmine.createSpyObj('CategoryService', ['getCategories']);

    TestBed.configureTestingModule({
      declarations: [ArticlesComponent],
      providers: [
        ArticlesComponent,
        {
          provide: CategoryService, useValue: spy
        },
        { provide: APP_BASE_HREF, useValue: '/' },
        { provide: 'BASE_URL', useValue: baseUrl }
      ],
      imports: [
        RouterModule.forRoot([]),
        FormsModule,
        HttpClientModule,
        HttpClientTestingModule
      ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ArticlesComponent);
    component = fixture.componentInstance;

    categoryServiceSpy = TestBed.get(CategoryService);

    let categories: Category[] = [
      {
        id: 1,
        name: 'c1'
      },
      {
        id: 2,
        name: 'c2'
      }
    ];

    categoryServiceSpy.getCategories.and.returnValue(of(categories));

    httpMock = TestBed.get(HttpTestingController);

    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });

  it('should get categories', () => {
    expect(Object.keys(component.categories).length).toBe(2);
    expect(component.categories[1]).not.toBeNull();
    expect(component.categories[2]).not.toBeNull();
  });

  it('should get articles', () => {
    //const req = httpMock.expectOne(baseUrl + 'api/Article/List');
    //expect(req.request.method).toEqual('GET');

    var result: ListArticles = {
      articles: [],
      numberOfPages: 10
    };

    //req.flush(result);

    //component.ngOnInit();
  });
});

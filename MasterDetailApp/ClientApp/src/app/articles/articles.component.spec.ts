import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { FormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { CategoryService } from '../services/category.service';
import { ArticlesComponent } from './articles.component';
import { APP_BASE_HREF } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';

describe('ArticlesComponent', () => {
  let component: ArticlesComponent;
  let fixture: ComponentFixture<ArticlesComponent>;

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
        { provide: 'BASE_URL', useValue: 'http://localhost' }
      ],
      imports: [
        RouterModule.forRoot([]),
        FormsModule,
        HttpClientModule
      ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ArticlesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

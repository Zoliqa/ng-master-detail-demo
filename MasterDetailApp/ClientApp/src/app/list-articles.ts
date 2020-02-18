import { Article } from './article';

export interface ListArticles {
  articles: Article[];
  numberOfPages: number;
}

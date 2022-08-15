import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Movies } from '../models/movies';

@Injectable({
  providedIn: 'root'
})
export class MovieListService {
  apiLoc: string = 'https://localhost:5001/api/movies';

  constructor(private http: HttpClient) { }

  public getMovies(){
    return this.http.get<Movies[]>(this.apiLoc);
  }

  public getAbove(rating: number){
    this.apiLoc + rating;
  }
}

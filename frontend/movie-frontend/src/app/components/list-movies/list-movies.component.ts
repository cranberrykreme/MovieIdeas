import { Component, OnInit } from '@angular/core';
import { Movies } from 'src/app/models/movies';
import { MovieListService } from 'src/app/services/movie-list.service';

@Component({
  selector: 'app-list-movies',
  templateUrl: './list-movies.component.html',
  styleUrls: ['./list-movies.component.css']
})
export class ListMoviesComponent implements OnInit {
  movieList: Movies[] = [];
  ratingSelected: string = "";

  constructor(private movieListService: MovieListService) { }

  ngOnInit(): void {
    this.movieListService.getMovies().subscribe((mov) =>{
      this.movieList = mov;
      console.log(this.movieList[0]);
    });
  }

  showWhatSelected(){
    console.log(this.ratingSelected);

    
  }

}

import { Component, OnInit } from '@angular/core';
import {HttpClientModule} from "@angular/common/http"
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { from } from 'rxjs';
import { Observable, of } from 'rxjs';
import { catchError, map, tap } from 'rxjs/operators';

@Component({
  selector: 'app-heroes',
  templateUrl: './heroes.component.html',
  styleUrls: ['./heroes.component.css']
})
export class HeroesComponent implements OnInit {
  // private url = "http://api/account/{accountViewModel.Username"
  private url = "http://api/video/demi"
  // http://api/
  constructor(private http: HttpClient){}

  // getVideos (): Object{
  //  return this.http.GetVideosFromUsername(this.url)
  // };

  // constructor() { }

  ngOnInit(): void {
  }

}

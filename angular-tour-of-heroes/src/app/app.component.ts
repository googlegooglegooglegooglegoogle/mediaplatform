import { Component } from '@angular/core';
import {VideoService} from './video.service';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  
  title: string = "FREEEEED";

  readonly ROOT_URL = 'https://jsonplaceholder.typicode.com/posts'

  posts: any;
  
  constructor(private http: HttpClient) {}
  
  getPosts() {
    this.posts = this.http.get(this.ROOT_URL)
  }
}

import {Injectable} from '@angular/core';

import {HttpClient} from '@angular/common/http';
import { Observable } from 'rxjs';
@Injectable()
export class VideoService {
  constructor(private http: HttpClient){}

  fetchVideos(): Observable<Object> {
   return this.http.get("/api/video/demi")
  //  return this.http.get("")
  }
}
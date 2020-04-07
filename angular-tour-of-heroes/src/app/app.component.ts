import { Component } from '@angular/core';
import {VideoService} from './video.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  video$;
  constructor(private videoService: VideoService){}
  fetchVideo() {
    this.video$ = this.videoService.fetchVideos();
  }
}

import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Song } from '../../Models/song';

@Injectable()
export class SongService {

  private url = "/api/songs";   

  constructor(private http: HttpClient) {
  }

  getSongs() {
    return this.http.get(this.url);
  }

  getSong(id: number) {
    return this.http.get(this.url + '/' + id);
  }

  createSong(song: Song) {
    return this.http.post(this.url, song);
  }
  updateSong(song: Song) {

    return this.http.put(this.url, song);
  }
  deleteSong(id: number) {
    return this.http.delete(this.url + '/' + id);
  }
}

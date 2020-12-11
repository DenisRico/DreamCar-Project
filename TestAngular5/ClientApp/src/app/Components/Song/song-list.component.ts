import { Component, OnInit } from '@angular/core';
import { SongService } from '../../Services/Song/song.service';
import { Song } from '../../Models/song';

@Component({
  templateUrl: './song-list.component.html',
  providers: [SongService]
})
export class SongComponent implements OnInit {

  songs: Song[];                 // массив товаров
  song: Song = new Song();   // изменяемый товар
  tableMode: boolean = true;          // табличный режим
  constructor(private songService: SongService) { }

  ngOnInit() {
    this.loadSongs();
  }
  ///Load Products function
  loadSongs() {
    this.songService.getSongs().subscribe((data: Song[]) => this.songs = data);
  }

  add() {
    this.cancel();
    this.tableMode = false;
  }

  delete(song: Song) {
    this.songService.deleteSong(song.id).subscribe(data => this.loadSongs());
  }
  ///Edit of product funktion
  editSong(p: Song) {
    this.song = p;
  }

  // сохранение данных
  save() {
    if (this.song.id == null) {
      this.songService.createSong(this.song)
        .subscribe((data: Song) => this.songs.push(data));
    } else {
      this.songService.updateSong(this.song)
        .subscribe(data => this.loadSongs());
    }
    this.cancel();
  }

  cancel() {
    this.song = new Song();
    this.tableMode = true;
  }

}

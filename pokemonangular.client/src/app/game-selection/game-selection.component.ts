import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { VersionGroup } from '../models/PokemonAPIModels';

@Component({
  selector: 'app-game-selection',
  templateUrl: './game-selection.component.html',
  styleUrl: './game-selection.component.css'
})
export class GameSelectionComponent implements OnInit {
  public versionGroups: VersionGroup[] = [];
  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.getPokemonGames();
  }

  getPokemonGames() {
    this.http.get<VersionGroup[]>('/versiongroup/all').subscribe(
      (result) => {
        this.versionGroups = result;
      },
      (error) => {
        console.error(error);
      }
    );
  }
}

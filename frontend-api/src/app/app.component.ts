import { HttpClient } from '@angular/common/http';
import { Component, inject, OnInit } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { Person } from './models/person';
import { CommonModule } from '@angular/common';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, CommonModule],
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})
export class AppComponent implements OnInit {
  title = 'UseApi';
  http = inject(HttpClient);
  url = 'http://localhost:5013';
  people$?: Observable<Person[]>;

  ngOnInit(): void {
    this.getPeople();
  }

  getPeople() {
    this.people$ = this.http.get<Person[]>(`${this.url}/people`)
  }
}



import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterOutlet } from '@angular/router';
import { TragedyComponent } from './tragedy/tragedy.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [CommonModule, RouterOutlet],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'AngularTheatre';
  otherVariable = 'Timmay!!!';
}

@Component( {
  selector: 'app-tragedy',
  standalone: true,
  imports: [CommonModule, RouterOutlet],
  templateUrl: './tragedy/tragedy.component.html',
  styleUrl: './tragedy/tragedy.component.css'
})
export class AppComponent2 {

}
import { Component } from '@angular/core';
import { AllCapsPipe } from '../Pipes/all-caps.pipe';

@Component({
  standalone: true,
  selector: 'app-comedy',
  templateUrl: './comedy.component.html',
  styleUrl: '../app.component.css',
  imports: [AllCapsPipe]
})
export class ComedyComponent {
  title = 'Comedy';
}

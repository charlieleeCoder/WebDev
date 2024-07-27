import { Component } from '@angular/core';
import { P1, P2, P3, P4, P5, P6, P7, title1, title2, title3} from './performancetext';
import { sections } from './performancetext';
import { NgClass, NgFor, NgForOf, CommonModule } from '@angular/common';
import { AllCapsPipe } from '../Pipes/all-caps.pipe';

@Component({
  standalone: true,
  selector: 'app-performance',
  templateUrl: './performance.component.html',
  styleUrl: '../app.component.css',
  imports: [
    NgFor, 
    NgClass, 
    NgForOf, 
    CommonModule,
    AllCapsPipe
  ]
})
export class PerformanceComponent {

  // Page title
  title = 'Performance';
  // Main paragraphs
  body: sections[] = [
    {title: title1, paragraphs: [P1, P2]},
    {title: title2, paragraphs: [P3, P4, P5]},
    {title: title3, paragraphs: [P6, P7]},
  ]

}

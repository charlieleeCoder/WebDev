import { Component } from '@angular/core';
import { performanceP1, performanceP2, performanceP3,  performanceP4, performanceP5, performanceP6, performanceP7} from './performancetext';
import { paragraphs } from './performancetext';
import { NgClass, NgFor, NgForOf, CommonModule } from '@angular/common';

@Component({
  standalone: true,
  selector: 'app-performance',
  templateUrl: './performance.component.html',
  styleUrl: '../app.component.css',
  imports: [NgFor, NgClass, NgForOf, CommonModule]
})
export class PerformanceComponent {

  // Page title
  title = 'Performance';
  // Main paragraphs
  p1=performanceP1;
  p2=performanceP2;
  p3=performanceP3;
  p4=performanceP4;
  p5=performanceP5;
  p6=performanceP6;
  p7=performanceP7;
  // Bootstrap + custom CSS classes
  right_paragraph = "col-12 col-xs-12 col-sm-6 col-md-6 col-lg-8 right-info"
  left_paragraph = "col-12 col-xs-12 col-sm-6 col-md-6 col-lg-8 left-info"
  // Avoid repetition
  overview_ps: paragraphs[] = [
    {text: this.p1},
    {text: this.p2}
  ];

}

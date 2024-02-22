import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NgClass, NgFor, NgIf } from '@angular/common';
import { p1, p2, p3, p4, p5, p6, h1, h2, h3, h4, h5, h6, titleParagraph} from './hometext'


@Component({
  standalone: true,
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrl: '../app.component.css',
  imports: [
    CommonModule,
    NgClass, 
    NgFor, 
    NgIf 
  ]
})
export class HomeComponent {
  title = 'Ancient Greece';
  items = [1, 2, 3, 4, 5, 6];
  body: titleParagraph[] = [
    {header: h1, paragraph: p1 },
    {header: h2, paragraph: p2 },
    {header: h3, paragraph: p3 },
    {header: h4, paragraph: p4 },
    {header: h5, paragraph: p5 },
    {header: h6, paragraph: p6 },
  ]
}

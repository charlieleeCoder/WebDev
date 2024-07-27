import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NgClass, NgFor, NgIf } from '@angular/common';
import { t1, t2, t3, p1s, p2s, p3s, sections } from './tragedytext'
import { AllCapsPipe } from '../Pipes/all-caps.pipe';

@Component({
  standalone: true,
  selector: 'app-tragedy',
  templateUrl: './tragedy.component.html',
  styleUrl: '../app.component.css',
  imports: [
    CommonModule,
    NgClass, 
    NgFor, 
    NgIf,
    AllCapsPipe 
  ]
})
export class TragedyComponent {
  title = 'Tragedy';
  body: sections[] = [
    {title: t1, img: '../assets/images/Aeschylus.jpg', alttext: 'Aeschylus, the playwright', paragraphs: p1s},
    {title: t2, img: '../assets/images/Sophocles.jpg', alttext: 'Sophocles, the playwright', paragraphs: p2s},
    {title: t3, img: '../assets/images/Euripides.jpg', alttext: 'Euripides, the playwright', paragraphs: p3s},
  ]
}

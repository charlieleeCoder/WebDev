import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NgClass, NgFor, NgIf } from '@angular/common';
import { t1, t2, t3, p1s, p2s, p3s, sections } from './comedytext'
import { AllCapsPipe } from '../Pipes/all-caps.pipe';

@Component({
  standalone: true,
  selector: 'app-comedy',
  templateUrl: './comedy.component.html',
  styleUrl: '../app.component.css',
  imports: [
    CommonModule,
    NgClass, 
    NgFor, 
    NgIf,
    AllCapsPipe
  ]
})
export class ComedyComponent {
  title = 'Comedy';
  body: sections[] = [
    {title: t1, img: '../assets/images/Aristophanes.jpg', alttext: 'Aristophanes, the playwright', paragraphs: p1s},
    {title: t2, img: '../assets/images/theatremask.jpg', alttext: 'A Classical theatre mask', paragraphs: p2s},
    {title: t3, img: '../assets/images/Menander.jpg', alttext: 'Menander, the playwright', paragraphs: p3s},
  ]
}

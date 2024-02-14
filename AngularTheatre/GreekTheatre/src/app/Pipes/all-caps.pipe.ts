import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'allCaps',
  standalone: true
})
export class AllCapsPipe implements PipeTransform {

  transform(value: string): string {
    return value.toUpperCase();
  }

}

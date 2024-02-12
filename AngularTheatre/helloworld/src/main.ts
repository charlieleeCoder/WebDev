import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';

import { AppComponent } from './app/app.component';
import { provideRouter } from '@angular/router';
import { AppRoutingModule } from './app/app-routing.module'

platformBrowserDynamic().bootstrapModule(AppComponent).catch(err => console.error(err));

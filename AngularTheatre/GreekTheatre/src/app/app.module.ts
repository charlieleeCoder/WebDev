import { NgModule } from '@angular/core';
import { BrowserModule, provideClientHydration } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './Home/home.component';
import { TragedyComponent } from './Tragedy/tragedy.component';
import { AllCapsPipe } from './Pipes/all-caps.pipe';
import { ComedyComponent } from './Comedy/comedy.component';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    AllCapsPipe,
    ComedyComponent,
    TragedyComponent,
    HomeComponent
  ],
  exports: [],
  providers: [
    provideClientHydration()
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }

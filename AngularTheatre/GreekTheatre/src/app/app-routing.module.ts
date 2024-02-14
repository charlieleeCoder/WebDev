import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './Home/home.component';
import { TragedyComponent } from './Tragedy/tragedy.component';
import { ComedyComponent } from './Comedy/comedy.component';
import { PerformanceComponent } from './Performance/performance.component';

const routes: Routes = [ 
  { path: 'tragedy', component: TragedyComponent, title: 'Tragedy'},  
  { path: 'comedy', component: ComedyComponent, title: 'Comedy'}, 
  { path: 'performance', component: PerformanceComponent, title: 'Performance'},
  { path: 'index', component: HomeComponent, title: 'Home'},
  { path: '', component: HomeComponent, title: 'Home'},

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {}

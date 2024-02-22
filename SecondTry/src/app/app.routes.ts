import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AppComponent } from './app.component';
import { TragedyComponent } from './tragedy.component';

export const routes: Routes = [
    { path: '', component: AppComponent},
    { path: 'tragedy', component: TragedyComponent},
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
})
export class AppRoutingModule{}
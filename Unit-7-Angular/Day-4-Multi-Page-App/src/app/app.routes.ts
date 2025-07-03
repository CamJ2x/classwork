import { Routes }        from '@angular/router';
import { HomeComponent } from './components/home/home.component';
import { SampleFormComponent } from './components/sample-form/sample-form.component';

export const routes: Routes = [
    {path: '', redirectTo: '/home', pathMatch: 'full' },
    {path: 'home', component: HomeComponent},
    {path: 'whatever', component:SampleFormComponent}
];

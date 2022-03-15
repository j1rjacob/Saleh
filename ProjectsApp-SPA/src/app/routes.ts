import {Routes} from '@angular/router';
import { AddprojectComponent } from './addproject/addproject.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { LoginComponent } from './login/login.component';
import { MytabsComponent } from './mytabs/mytabs.component';

import { RegisterComponent } from './register/register.component';
import { AuthGuard } from './_guards/auth.guard';

export const appRoutes: Routes = [
  { path: '', component: LoginComponent },
  { path: 'login', component: LoginComponent },
  { path: 'dashboard', component: DashboardComponent },
  { path: 'register', component: RegisterComponent },
  { path: 'addproject', component: AddprojectComponent },
  { path: 'tabs', component: MytabsComponent },
  { path: '**', redirectTo: 'home', pathMatch: 'full' }
];

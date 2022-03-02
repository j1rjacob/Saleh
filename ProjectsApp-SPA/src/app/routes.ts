import {Routes} from '@angular/router';
import { AddprojectComponent } from './addproject/addproject.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';
import { AuthGuard } from './_guards/auth.guard';

export const appRoutes: Routes = [
  { path: '', component: LoginComponent },
  { path: 'login', component: LoginComponent },
  { path: 'dashboard', component: DashboardComponent },
  { path: 'register', component: RegisterComponent },
  { path: 'addproject', component: AddprojectComponent },
  {
    path: 'dashboard', component: DashboardComponent,
    runGuardsAndResolvers: 'always',
    canActivate: [AuthGuard],
    // children: [
    //    { path: 'members', component: MemberListComponent, resolve: {users: MemberListResolver} },
    //    { path: 'members/:id', component: MemberDetailComponent, resolve: {user: MemberDetailResolver} },
    //    { path: 'member/edit', component: MemberEditComponent,
    //       resolve: {user: MemberEditResolver},
    //       canDeactivate: [PreventUnsavedChanges]},
    //    { path: 'messages', component: MessagesComponent, resolve: {messages: MessagesResolver} },
    //    { path: 'lists', component: ListsComponent, resolve: {users: ListsResolver} }
    // ]
  },
  { path: '**', redirectTo: 'home', pathMatch: 'full' }
];

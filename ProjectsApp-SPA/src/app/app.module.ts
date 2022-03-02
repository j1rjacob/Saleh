import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { RouterModule } from '@angular/router';
import { ChartsModule } from 'ng2-charts';
import { JwtModule } from '@auth0/angular-jwt';

import { AppComponent } from './app.component';
import { AuthService } from './_services/auth.service';
import { ValuesComponent } from './values/values.component';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { AddprojectComponent } from './addproject/addproject.component';
import { appRoutes } from './routes';
import { AuthGuard } from './_guards/auth.guard';
import { AlertifyService } from './_services/alertify.service';
import { ProjectService } from './_services/project.service';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { BsDatepickerModule } from 'ngx-bootstrap/datepicker';

export function tokenGetter() {
  return localStorage.getItem('token');
}

@NgModule({
  declarations: [
    AppComponent,
      ValuesComponent,
      LoginComponent,
      RegisterComponent,
      DashboardComponent,
      AddprojectComponent
   ],
  imports: [
    BrowserModule,
    HttpClientModule,
    RouterModule.forRoot(appRoutes),
    FormsModule,
    ReactiveFormsModule,
    ChartsModule,
    JwtModule.forRoot({
      config: {
        tokenGetter: tokenGetter,
        allowedDomains: ['localhost:5000'],
        disallowedRoutes: ['localhost:5000/api/auth'],
      }
    }),
    BrowserAnimationsModule,
    BsDatepickerModule.forRoot()
  ],
  providers: [
    AuthService,
    ProjectService,
    AlertifyService,
    AuthGuard
  ],
  bootstrap: [AppComponent]

})
export class AppModule { }

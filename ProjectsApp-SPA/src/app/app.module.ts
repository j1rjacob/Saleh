import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { ChartsModule } from 'ng2-charts';

import { AppComponent } from './app.component';
import { ValuesComponent } from './values/values.component';
import { TimeProgressComponent } from './TimeProgress/TimeProgress.component';

@NgModule({
  declarations: [
    AppComponent,
      ValuesComponent,
      TimeProgressComponent
   ],
  imports: [
    BrowserModule,
    HttpClientModule,
    FormsModule,
    ChartsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

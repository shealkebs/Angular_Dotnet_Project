import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms'
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import {HttpClientModule} from '@angular/common/http';

import { SearchClientsComponent } from './search-clients/search-clients.component';

import { DisplaySearchResultComponent } from './display-search-result/display-search-result.component';

@NgModule({
  declarations: [
    AppComponent,

    SearchClientsComponent,

    DisplaySearchResultComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule,
  
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

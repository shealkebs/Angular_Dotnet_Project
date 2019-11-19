import { Injectable } from '@angular/core';
import { Client } from './client.model'
import { HttpClient, HttpHeaders } from '@angular/common/http';

import { Observable } from "rxjs";
import { map } from "rxjs/operators";
import "rxjs/add/operator/map";
import "rxjs/add/operator/topromise";
import 'rxjs/add/operator/catch';

import { SearchClientsComponent } from '../search-clients/search-clients.component';
@Injectable({
  providedIn: 'root'
})
export class ClientService {

 selectedClient: Client;
 searchClient: Client;  
 // readonly rootURL="https://localhost:44386"
  readonly rootURL="https://localhost:44386/api/ClientInformations"
  constructor(private httpClient:HttpClient) { }
/* 
  getClientList(): Observable<Client[]> 
    {
      return this.httpClient.get<Client[]> (this.rootURL);
    }
*/
    getSearchClient(client:Client): Observable<Client[]> 
    {
     
      var fnm=this.selectedClient.FirstName;
      var lnm=this.selectedClient.LastName;

    //  console.log(this.rootURL + '/FirstName/'+fnm+'/LastName/'+lnm);
     //  return this.httpClient.get<Client[]> (this.rootURL + '/FirstName/'+fnm+'/LastName/'+lnm);

      console.log(this.rootURL + '?fName='+fnm+'&lName='+lnm);
      return this.httpClient.get<Client[]> (this.rootURL + '?fName='+fnm+'&lName='+lnm);
    }

}

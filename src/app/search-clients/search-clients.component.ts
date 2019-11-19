import { Component, OnInit } from '@angular/core';
import { ClientService } from '../shared/client.service'
import { NgForm } from '@angular/forms'
import { format } from 'url';
import { Client } from '../shared/client.model';
@Component({
  selector: 'app-search-clients',
  templateUrl: './search-clients.component.html',
  styleUrls: ['./search-clients.component.css']
})
export class SearchClientsComponent implements OnInit {
  client = new Client();
  searchedclients=[];
constructor(private clientService : ClientService) { }

  ngOnInit() {
            this.resetForm();           
          // this.clientService.getClientList().subscribe(res => {this.searchedclients=res;});
    }
    
 
    searchForm(client:Client){
                  //   alert("In serch area");
                  //   alert(this.clientService.selectedClient.FirstName);
                  //   alert(this.clientService.selectedClient.LastName);
                     this.clientService.getSearchClient(this.client).subscribe(res => {this.searchedclients=res;}); 
    
  }

    resetForm(form?:NgForm){
                              if(form !=null)
                                form.reset();     
                            this.clientService.selectedClient=
                              {
                                ClientID:null,
                                FirstName:'',
                                LastName:'',
                                BirthDate:null,
                                Address:[]
                              }
      }

}

import { Component, OnInit, Input } from '@angular/core';
import { ClientService } from '../shared/client.service';
import { Client } from '../shared/client.model';

@Component({
  selector: 'app-display-search-result',
  templateUrl: './display-search-result.component.html',
  styleUrls: ['./display-search-result.component.css']
})
export class DisplaySearchResultComponent implements OnInit {
  @Input() Searchedclients;
 // public client1=[];
  constructor(private clientService : ClientService) { }

  ngOnInit() {
    
//    this.clientService.getSearchClient().subscribe(res => {this.client1=res;}); 
    
  }
  
}

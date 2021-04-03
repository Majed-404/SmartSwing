import { Component, OnInit } from '@angular/core';
import { InfoCardsComponent } from 'src/app/admin/dashboard/info-cards/info-cards.component';


@Component({
  selector: 'app-stocks',
  templateUrl: './stocks.component.html',
  styleUrls: ['./stocks.component.scss']
})
export class StocksComponent implements OnInit {

  public infocards : InfoCardsComponent

  
  public toggleSearchBar:boolean = false;



  constructor() { }

  ngOnInit(): void {
  }

  
}

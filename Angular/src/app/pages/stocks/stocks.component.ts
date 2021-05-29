import { Component, OnInit, ViewEncapsulation } from '@angular/core';
import { FormControl } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-stocks',
  templateUrl: './stocks.component.html',
  styleUrls: ['./stocks.component.scss'],
  // encapsulation: ViewEncapsulation.ShadowDom
})
export class StocksComponent implements OnInit {

  // public toggleSearchBar:boolean = false;
  public myControl = new FormControl();
  public id:number;
  public stockItem: any[];

  constructor() { }

  ngOnInit(): void {
    
    this.stockItem = [
      { name : "sabic" , price: 130, volume: 3024872 , bid:124.00 , ask: 124.20, low: 122 , high: 124.230}
      ];
  
  }

}

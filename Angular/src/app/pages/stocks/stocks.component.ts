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



  constructor() { }

  ngOnInit(): void {
    
    
  }

}

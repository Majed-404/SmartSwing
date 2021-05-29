import { Component, OnInit } from '@angular/core';
import { Settings, AppSettings } from 'src/app/app.settings';
import { AppService } from 'src/app/app.service';  
import { MenuItem } from 'src/app/app.models';
import { VisitorMarketService } from 'src/app/shared/visitors-markets/visitor-market-.service';
import { Stocks } from 'src/app/shared/visitors-markets/stocks.model';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {  
  public slides = []; 
  public title = "Impressive Record in Detecting Significant Trades";
  public desc = "Improve Performance and Maximize Profits  The Best Stock Picking and Trend Identifying System";
  public specialMenuItems:Array<MenuItem> = [];
  public bestMenuItems:Array<MenuItem> = [];
  public todayMenu:MenuItem;

  public settings: Settings;
  
  constructor(public appSettings:AppSettings, public appService:AppService,
    private _VisitorMarketService:VisitorMarketService ) {
    this.settings = this.appSettings.settings;  
  }

  ngOnInit(): void {
    this.getSlides();
    this.getSpecialMenuItems();
    this.getBestMenuItems();
    this.getTodayMenu();
  }

  public getSlides(){
    // this.appService.getHomeCarouselSlides().subscribe(res=>{
    //   this.slides = res;
    // });
      debugger
      this._VisitorMarketService.getVisitorStocks(2).subscribe(data => {
       this.slides = <Stocks[]>data;
      });
  }
 
  public getSpecialMenuItems(){
    this.appService.getSpecialMenuItems().subscribe(menuItems=>{
      this.specialMenuItems = menuItems;
    });
  } 

  public getBestMenuItems(){
    this.appService.getBestMenuItems().subscribe(menuItems=>{
      this.bestMenuItems = menuItems;
    });
  }

  public getTodayMenu(){
    debugger
    this.appService.getMenuItemById(17).subscribe(data=>{ 
      this.todayMenu = data;  
    });
  }  

}

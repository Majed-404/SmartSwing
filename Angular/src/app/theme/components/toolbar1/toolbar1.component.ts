import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import { FormControl } from '@angular/forms';
import { Observable } from 'rxjs';
import { AppService } from 'src/app/app.service'; 
import { AppSettings, Settings } from 'src/app/app.settings';
import { CartOverviewComponent } from 'src/app/shared/cart-overview/cart-overview.component'; 
import { ReservationDialogComponent } from 'src/app/shared/reservation-dialog/reservation-dialog.component';
import { HomebarService } from './_services/homebar.service';

@Component({
  selector: 'app-toolbar1',
  templateUrl: './toolbar1.component.html' 
})
export class Toolbar1Component implements OnInit {

  @Output() onMenuIconClick: EventEmitter<any> = new EventEmitter<any>(); 
  

  public toggleSearchBar:boolean = false;
  
  myControl = new FormControl();
  filteredOptions: Observable<string[]>;

  
  _listFilter: string ;
  get listFilter(): string{
    return this._listFilter;
  }

  set listFilter(value: string){
    
      this._listFilter= value;
      this.filterData = this.listFilter ? this.performData(this.listFilter) : this.apiData;
      console.log("set"+this.filterData.length);
  }
  apiData: Users[];
  filterData: Users[]=[];

  public settings:Settings;

  constructor(public appService:AppService,public homebar:HomebarService,
    public appSettings:AppSettings, ) {this.settings = this.appSettings.settings; }

  performData(filterBy: string): Users[] {
    filterBy = filterBy.toLocaleLowerCase();
    return this.apiData.filter((product: Users) =>
      product.username.toLocaleLowerCase().indexOf(filterBy) !== -1);
  }
  

  ngOnInit() {

    this.homebar.getData().subscribe(data => {
      this.apiData=data;
      this.filterData=this.apiData;
    });

   }

  public sidenavToggle(){
    this.onMenuIconClick.emit();
  }
  public openCart(){ 
    this.appService.openCart(CartOverviewComponent)
  }
  public reservation(){ 
    this.appService.makeReservation(ReservationDialogComponent, null, true);   
  }
}


export class Users {
  id:number;
  name: string;
  username: string;
  email: string;
}
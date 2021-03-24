import { Component, OnInit } from '@angular/core';
import { FormControl } from '@angular/forms';
import { Observable } from 'rxjs';
import { InfoCardsComponent } from 'src/app/admin/dashboard/info-cards/info-cards.component';
import { Stocks } from './stockes.model';


@Component({
  selector: 'app-stocks',
  templateUrl: './stocks.component.html',
  styleUrls: ['./stocks.component.scss']
})
export class StocksComponent implements OnInit {

  public infocards : InfoCardsComponent

  public stocks : Stocks[] ;
  public filteredOptions: Observable<string[]>;
  public filterData: Stocks[]=[];
  public _listFilter: string ;
  public toggleSearchBar:boolean = false;
  myControl = new FormControl();

  get listFilter(): string{
    return this._listFilter;
  }

  set listFilter(value: string){
    
      this._listFilter= value;
      this.filterData = this.listFilter ? this.performData(this.listFilter) : this.stocks;
      console.log("set"+this.filterData.length);
  }

  constructor() { }

  ngOnInit(): void {
  }

  public performData(filterBy: string): Stocks[] {
    filterBy = filterBy.toLocaleLowerCase();
    return this.stocks.filter((product: Stocks) =>
      product.name.toLocaleLowerCase().indexOf(filterBy) !== -1);
  }

}

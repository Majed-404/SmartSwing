import { Component, OnInit } from '@angular/core';
import { FormControl } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Observable } from 'rxjs';
import { InfoCardsComponent } from 'src/app/admin/dashboard/info-cards/info-cards.component';
import { AccountService } from '../account-service.service';
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
  public id:number;

  get listFilter(): string{
    return this._listFilter;
  }

  set listFilter(value: string){
    
      this._listFilter= value;
      this.filterData = this.listFilter ? this.performData(this.listFilter) : this.stocks;
      console.log("set"+this.filterData.length);
  }

  constructor(public accountService:AccountService,public router: Router,private route: ActivatedRoute) { }

  ngOnInit(): void {
    debugger
    this.id = this.route.snapshot.params['id'];
    this.accountService.getStocksList(2).subscribe(data => {
      this.stocks=data;
      this.filterData=this.stocks;
    });
  }

  public performData(filterBy: string): Stocks[] {
    filterBy = filterBy.toLocaleLowerCase();
    return this.stocks.filter((stck: Stocks) =>
    stck.nmEnName.toLocaleLowerCase().indexOf(filterBy) !== -1
    ||stck.nmSymbol.toLocaleLowerCase().indexOf(filterBy) !== -1
    );
  }

}

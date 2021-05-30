import { Component, OnInit } from '@angular/core';
import { FormControl } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Observable } from 'rxjs';
import { AccountService } from '../account-service.service';
import { Stocks } from '../stocks/stockes.model';

@Component({
  selector: 'app-stocks-market',
  templateUrl: './stocks-market.component.html',
  styleUrls: ['./stocks-market.component.scss']
})
export class StocksMarketComponent implements OnInit {

  public stocks : Stocks[] ;
  public filteredOptions: Observable<string[]>;
  public filterData: Stocks[]=[];
  public _listFilter: string ;
  myControl = new FormControl();
  public id:number;

  get listFilter(): string{
    return this._listFilter;
  }

  set listFilter(value: string){
    
      this._listFilter= value;
      this.filterData = this.listFilter ? this.performData(this.listFilter) : this.stocks;
  }

  constructor(public accountService:AccountService,public router: Router,private route: ActivatedRoute) { }

  ngOnInit(): void {
    //this.id = this.route.snapshot.params['id'];
    this.accountService.getStocksList(2).subscribe(data => {
      this.stocks=data;
      this.filterData=this.stocks;
    });
  }

  public performData(filterBy: string): Stocks[] {
    filterBy = filterBy.toLocaleLowerCase();
    return this.stocks.filter((stck: Stocks) =>
      stck.nmSymbol.toLocaleLowerCase().indexOf(filterBy) !== -1 ||
      stck.nmEnName.toLocaleLowerCase().indexOf(filterBy) !== -1);
  }
  Change(id){
    this.router.navigate(["/stock",id]);
  }

}

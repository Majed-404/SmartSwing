import { Component, OnInit, ViewChild } from '@angular/core';
import { FormControl } from '@angular/forms';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { ActivatedRoute, Router } from '@angular/router';
import { Observable } from 'rxjs';
import { MarketsService } from '../markets.service';
import { Stocks } from '../stocks.model';

@Component({
  selector: 'app-stocks-market',
  templateUrl: './stocks-market.component.html',
  styleUrls: ['./stocks-market.component.scss']
})
export class StocksMarketComponent implements OnInit {

  public displayedColumns = ['Symbol', 'Name', 'Close', 'Volume', 'Value'];
  
  public dataSource : MatTableDataSource<Element> ;
  public stocksList: Stocks[];
  @ViewChild(MatPaginator) paginator: MatPaginator;
  @ViewChild(MatSort) sort: MatSort;

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

  constructor(public marketsService:MarketsService,public router: Router,private route: ActivatedRoute) { }

  ngOnInit(): void {
    //this.id = this.route.snapshot.params['id'];
    this.getStocksSearch();
    this.getStocksList();
    
  }

  public getStocksSearch(){
    this.marketsService.getStocksList(2).subscribe(data => {
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

  public getStocksList(){
    this.marketsService.getVisitorStocks(2).subscribe(data => {
     this.stocksList = <Stocks[]>data;
     this.initDataSource(this.stocksList)
    });
  }

  public initDataSource(data:any){
    debugger
  this.dataSource = new MatTableDataSource(data);
  this.dataSource.paginator = this.paginator;
  this.dataSource.sort = this.sort; 
  } 

}

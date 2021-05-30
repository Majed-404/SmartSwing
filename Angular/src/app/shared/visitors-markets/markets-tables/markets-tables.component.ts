import { HttpClient } from '@angular/common/http';
import { Component, OnInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { Stocks } from 'src/app/pages/account/stocks/stockes.model';
import { VisitorMarketService } from '../visitor-market-.service';

@Component({
  selector: 'app-markets-tables',
  templateUrl: './markets-tables.component.html',
  styleUrls: ['./markets-tables.component.scss']
})
export class MarketsTablesComponent implements OnInit {

  public displayedColumns = ['Symbol', 'Name', 'Close', 'Volume', 'Value'];
   
  public dataSource : MatTableDataSource<Element> ;
  public stocksList: Stocks[];
  //public url = "http://localhost:49974/api/Markets/StockListExchange/{Id}";
  @ViewChild(MatPaginator) paginator: MatPaginator;
  @ViewChild(MatSort) sort: MatSort;

  constructor(private http: HttpClient,private _VisitorMarketService:VisitorMarketService) {
    
  }

  ngOnInit() {

    this.getStocksList();
    
  } 

  public getStocksList(){
    this._VisitorMarketService.getVisitorStocks(2).subscribe(data => {
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


import { Component, OnInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { Router } from '@angular/router';
import { Markets } from './markets.model';
import { MarketsService } from './markets.service';

@Component({
  selector: 'app-markets',
  templateUrl: './markets.component.html',
  styleUrls: ['./markets.component.scss']
})
export class MarketsComponent implements OnInit {

  markets: Markets[];

  displayedColumns: string[] = ['image', 'name'];
  dataSource: MatTableDataSource<any>;
  @ViewChild(MatPaginator, {static: true}) paginator: MatPaginator;
  @ViewChild(MatSort, {static: true}) sort: MatSort;

  constructor(private router: Router,public marketsService:MarketsService) { }

  ngOnInit(): void {
    this.getGroupList();
  }

 

  onPageChanged($event){

  }
  public getGroupList(){
    debugger
    this.marketsService.getMarketsList().subscribe(response => {
      this.markets=<Markets[]>response;
      this.initDataSource(this.markets); 
    })
  }
  public initDataSource(data:any){
    this.dataSource = new MatTableDataSource(data);
    this.dataSource.paginator = this.paginator;
    this.dataSource.sort = this.sort;  
  } 

  onClick(id){
    debugger
    this.router.navigate(["/markets/stocks-market",id]);
  }


}

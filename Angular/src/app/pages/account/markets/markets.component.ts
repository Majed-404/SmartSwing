import { Component, OnInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { Router } from '@angular/router';


@Component({
  selector: 'app-markets',
  templateUrl: './markets.component.html',
  styleUrls: ['./markets.component.scss']
})
export class MarketsComponent implements OnInit {

  
  markets: Markets[]= [{name: 'Reyad'},{name: "cairo"},{name: "dubai"},{name: "amman"},{name: "kwite"},{ name:"iraq"}];

  displayedColumns: string[] = ['image', 'name'];
  dataSource: MatTableDataSource<any>;
  @ViewChild(MatPaginator, {static: true}) paginator: MatPaginator;
  @ViewChild(MatSort, {static: true}) sort: MatSort;

  constructor(private router: Router) { }

  ngOnInit(): void {
    this.initDataSource(this.markets)
  }

 

  onPageChanged($event){

  }

  public initDataSource(data:any){
    this.dataSource = new MatTableDataSource(data);
    this.dataSource.paginator = this.paginator;
    this.dataSource.sort = this.sort;  
  } 

  onClick(){
    this.router.navigate(["/account/stocks"]);
  }

}

export class Markets{
  name: string;
}

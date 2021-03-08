import { Component, OnInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator'; 
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table'; 
import { Router } from '@angular/router';
import { response } from 'express';
import { AppService } from 'src/app/app.service'; 
import { UserManagemntService } from '../menu-items/user-managemnt.service';
import { AdminMails, reviews } from './reviews';

@Component({
  selector: 'app-reviews',
  templateUrl: './reviews.component.html',
  styleUrls: ['./reviews.component.scss']
})
export class ReviewsComponent implements OnInit {
  displayedColumns: string[] = ['id', 'subject', 'createDate', 'isSent', 'sendDate', 'ispublic', 'actions'];
  dataSource: MatTableDataSource<any>;
  @ViewChild(MatPaginator, {static: true}) paginator: MatPaginator;
  @ViewChild(MatSort, {static: true}) sort: MatSort;
  
public adminMails:AdminMails[];
  constructor(public appService:AppService,public router: Router,
    public userManagement:UserManagemntService) { }

  ngOnInit(): void { 
    this.getMailsList(); 
  }
  getMailsList(){
    debugger
    this.userManagement.getAdminMails().subscribe(response=>{
      this.adminMails=<AdminMails[]>response;
      this.initDataSource(this.adminMails); 
    });
  }
public openCreateMail(){
this.router.navigate(['admin/addMails'])
}
  public initDataSource(data:any){
    this.dataSource = new MatTableDataSource(data);
    this.dataSource.paginator = this.paginator;
    this.dataSource.sort = this.sort; 
  } 


  

}

import { Component, OnInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator'; 
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table'; 
import { Router } from '@angular/router';
import { AppService } from 'src/app/app.service'; 
import { UserManagemntService } from '../menu-items/user-managemnt.service';
import { AdminMails, reviews } from './reviews';
import { AdminMailService } from './_services/admin-mail.service';

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
    public userManagement:UserManagemntService,
    public adminMailService: AdminMailService) { }

  ngOnInit(): void { 
    this.getMailsList(); 
  }
  public getMailsList(){
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


  public remove(email:any) {
   
    const index: number = this.dataSource.data.indexOf(email);    
    if (index !== -1) {
      const message = this.appService.getTranslateValue('MESSAGE.SURE_DELETE');
			let dialogRef = this.appService.openConfirmDialog(null, message);
			dialogRef.afterClosed().subscribe(dialogResult => {
				if(dialogResult){ 

          this.adminMailService.deleteMail(email.id).subscribe(response => {
            if(response){
              
              this.getMailsList();
            }
            else {
              alert("something bad happened ")
            }
          });
				}
			});  
    } 
  }  

}

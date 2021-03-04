import { Component, OnInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatSnackBar } from '@angular/material/snack-bar';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { Group } from 'src/app/app.models';
import { AppService } from 'src/app/app.service';
import { UserManagemntService } from '../user-managemnt.service';
import { GroupDialogComponent } from './group-dialog/group-dialog.component';

@Component({
  selector: 'app-groups',
  templateUrl: './groups.component.html',
  styleUrls: ['./groups.component.scss']
})
export class GroupsComponent implements OnInit {

  displayedColumns: string[] = ['id', 'name', 'edit', 'remove'];
  dataSource: MatTableDataSource<Group>;
  @ViewChild(MatPaginator, {static: true}) paginator: MatPaginator;
  @ViewChild(MatSort, {static: true}) sort: MatSort;

  constructor(public userManagemntService:UserManagemntService,public appService:AppService, public snackBar: MatSnackBar) { }

  ngOnInit(): void {
    this.userManagemntService.getGroups().subscribe((groups:Group[]) => {
      this.initDataSource(groups); 
    })
  }

  public initDataSource(data:any){
    this.dataSource = new MatTableDataSource(data);
    this.dataSource.paginator = this.paginator;
    this.dataSource.sort = this.sort; 
  } 
 
  public remove(group:Group) {
    const index: number = this.dataSource.data.indexOf(group);    
    if (index !== -1) {
      const message = this.appService.getTranslateValue('MESSAGE.SURE_DELETE');
			let dialogRef = this.appService.openConfirmDialog(null, message);
			dialogRef.afterClosed().subscribe(dialogResult => {
				if(dialogResult){ 
          this.dataSource.data.splice(index,1);
          this.initDataSource(this.dataSource.data); 
				}
			});  
    } 
  }  

  public openGroupDialog(group:Group){
    const dialogRef = this.appService.openDialog(GroupDialogComponent, group, 'theme-dialog');
    dialogRef.afterClosed().subscribe(grp => {  
      if(grp){
        let message = '';      
        const index: number = this.dataSource.data.findIndex(x => x.id == grp.id); 
        if(index !== -1){
          this.dataSource.data[index] = grp;
          message = 'group '+grp.name+' updated successfully';
        } 
        else{ 
          let last_group = this.dataSource.data[this.dataSource.data.length - 1]; 
          grp.id = last_group.id + 1; 
          this.dataSource.data.push(grp); 
          this.paginator.lastPage();
          message = 'New group '+grp.name+' added successfully!'; 
        }  
        this.initDataSource(this.dataSource.data); 
        this.snackBar.open(message, '×', { panelClass: 'success', verticalPosition: 'top', duration: 3000 });          
      }
    });  
  }

}

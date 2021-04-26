import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { MatPaginator } from '@angular/material/paginator';
import { MatSnackBar } from '@angular/material/snack-bar';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { Group } from 'src/app/app.models';
import { AppService } from 'src/app/app.service';
import { AppUsersService } from '../../users/_services/app.users.service';
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
  public groups:Group[];
  constructor(public userManagemntService:UserManagemntService,
    public appService:AppService, 
    //public appUsersService: AppUsersService,
    public snackBar: MatSnackBar,
    public dialog: MatDialog,) { }

  ngOnInit(): void {
    this.getGroupList();
  }
public getGroupList(){
  this.userManagemntService.getGroups().subscribe(response => {
    this.groups=<Group[]>response;
    this.initDataSource(this.groups); 
  })
}
  public initDataSource(data:any){
    
    this.dataSource = new MatTableDataSource(data);
    this.dataSource.paginator = this.paginator;
    this.dataSource.sort = this.sort; 
  } 
 
  public addGroup(group: Group) {
    this.userManagemntService.addGroup(group).subscribe(response=>{
        if(response){
            this.getGroupList();
       }
    });
}
public updateGroup(group: Group) {
    this.userManagemntService.updateGroup(group).subscribe(response=>{
        if(response){
          this.getGroupList();
        }
    });
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
  public openGroupDialog(group) {
    let dialogRef = this.dialog.open(GroupDialogComponent, {
        data: group
    });

    dialogRef.afterClosed().subscribe(group => {
        
        if (group) {
            (group.id) ? this.updateGroup(group) : this.addGroup(group);
        }
    });
  
}

public deleteGroup(group: Group){

  const index: number = this.groups.indexOf(group);    
        if (index !== -1) {
        const message = this.appService.getTranslateValue('MESSAGE.SURE_DELETE');
                let dialogRef = this.appService.openConfirmDialog(null, message);
                dialogRef.afterClosed().subscribe(dialogResult => {
                    if(dialogResult){ 

                        this.userManagemntService.deleteGroup(group.id).subscribe(response => {
                if(response){
                
                  this.getGroupList();
                }
                else {
                alert("something bad happened ")
                }
            });
                    }
                });  
        } 


  // this.userManagemntService.deleteGroup(group.id).subscribe((response) => {
  //   if(response === true){
  //     const index = this.groups.indexOf(group, 0);
  //     if(index > -1){
  //       this.getGroupList();      }
  //   } else { alert("Som Thing Bad Happen !");}
  // })
}


  // public openGroupDialog(group:Group){
  //   const dialogRef = this.appService.openDialog(GroupDialogComponent, group, 'theme-dialog');
  //   dialogRef.afterClosed().subscribe(grp => {  
  //     if(grp){
  //       let message = '';      
  //       const index: number = this.dataSource.data.findIndex(x => x.id == grp.id); 
  //       if(index !== -1){
  //         this.dataSource.data[index] = grp;
  //         message = 'group '+grp.name+' updated successfully';
  //       } 
  //       else{ 
  //         let last_group = this.dataSource.data[this.dataSource.data.length - 1]; 
  //         grp.id = last_group.id + 1; 
  //         this.dataSource.data.push(grp); 
  //         this.paginator.lastPage();
  //         message = 'New group '+grp.name+' added successfully!'; 
  //       }  
  //       this.initDataSource(this.dataSource.data); 
  //       this.snackBar.open(message, '×', { panelClass: 'success', verticalPosition: 'top', duration: 3000 });          
  //     }
  //   });  
  // }

}

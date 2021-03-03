import { Component, OnInit,ViewChild } from '@angular/core';
import { Role } from 'src/app/app.models';
import { MatPaginator } from '@angular/material/paginator'; 
import { MatSnackBar } from '@angular/material/snack-bar';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table'; 
import { AppService } from 'src/app/app.service';

@Component({
  selector: 'app-roles',
  templateUrl: './roles.component.html',
  styleUrls: ['./roles.component.scss']
})
export class RolesComponent implements OnInit {

  displayedColumns: string[] = ['id', 'name', 'edit', 'remove'];
  dataSource: MatTableDataSource<Role>;
  @ViewChild(MatPaginator, {static: true}) paginator: MatPaginator;
  @ViewChild(MatSort, {static: true}) sort: MatSort;

  constructor(public appService:AppService, public snackBar: MatSnackBar) { }

  ngOnInit(): void {
    this.appService.getRolesList().subscribe((roles:Role[]) => {
      this.initDataSource(roles); 
    })
  }

  public initDataSource(data:any){
    this.dataSource = new MatTableDataSource(data);
    this.dataSource.paginator = this.paginator;
    this.dataSource.sort = this.sort; 
  } 
  public remove(role:Role) {
    // const index: number = this.dataSource.data.indexOf(Role);    
    // if (index !== -1) {
    //   const message = this.appService.getTranslateValue('MESSAGE.SURE_DELETE');
		// 	let dialogRef = this.appService.openConfirmDialog(null, message);
		// 	dialogRef.afterClosed().subscribe(dialogResult => {
		// 		if(dialogResult){ 
    //       this.dataSource.data.splice(index,1);
    //       this.initDataSource(this.dataSource.data); 
		// 		}
		// 	});  
    } 
    

  public openRoleDialog(role:Role){
    // const dialogRef = this.appService.openDialog(RoleDialogComponent, Role, 'theme-dialog');
    // dialogRef.afterClosed().subscribe(cat => {  
    //   if(cat){
    //     let message = '';      
    //     const index: number = this.dataSource.data.findIndex(x => x.id == cat.id); 
    //     if(index !== -1){
    //       this.dataSource.data[index] = cat;
    //       message = 'Role '+cat.name+' updated successfully';
    //     } 
    //     else{ 
    //       let last_Role = this.dataSource.data[this.dataSource.data.length - 1]; 
    //       cat.id = last_Role.id + 1; 
    //       this.dataSource.data.push(cat); 
    //       this.paginator.lastPage();
    //       message = 'New Role '+cat.name+' added successfully!'; 
    //     }  
    //     this.initDataSource(this.dataSource.data); 
    //     this.snackBar.open(message, '×', { panelClass: 'success', verticalPosition: 'top', duration: 3000 });          
    //   }
    // });  
  }
}

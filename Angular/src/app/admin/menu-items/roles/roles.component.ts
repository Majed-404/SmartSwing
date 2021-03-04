import { Component, OnInit,ViewChild } from '@angular/core';
import { Role } from 'src/app/app.models';
import { MatPaginator } from '@angular/material/paginator'; 
import { MatSnackBar } from '@angular/material/snack-bar';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table'; 
import { AppService } from 'src/app/app.service';
import { RoleDialogComponent } from './role-dialog/role-dialog.component';
import { UserManagemntService } from '../user-managemnt.service';

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

  constructor(public appService:AppService,public userManagemntService:UserManagemntService, public snackBar: MatSnackBar) { }

  ngOnInit(): void {
    this.getRolesList();
  }
getRolesList(){
  this.userManagemntService.getRolesList().subscribe((roles:Role[]) => {
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
    debugger
    let message = '';   
     const dialogRef = this.appService.openDialog(RoleDialogComponent, role, 'theme-dialog');
    dialogRef.afterClosed().subscribe(rol => {  
      if(rol){
        
        this.userManagemntService.editRole(role).subscribe((roles:Role)=>{
          message = 'Role '+rol.name+' updated successfully';
          this.getRolesList();
        });   
        // const index: string = this.dataSource.data.findIndex(x => x.id == rol.id); 
        // if(index !== null){
        //   this.dataSource.data[index] = rol;
          
        } 
        else{ 
          let last_Role = this.dataSource.data[this.dataSource.data.length - 1]; 
          this.userManagemntService.createRole(rol).subscribe(()=>{
            message = 'New Role '+rol.name+' added successfully!'; 
            this.getRolesList();
          });
          // rol.id = last_Role.id + 1; 
          // this.dataSource.data.push(rol); 
          this.paginator.lastPage();
        }  
       // this.initDataSource(this.dataSource.data); 
        this.snackBar.open(message, '×', { panelClass: 'success', verticalPosition: 'top', duration: 30000 });          
      });  
  }
}

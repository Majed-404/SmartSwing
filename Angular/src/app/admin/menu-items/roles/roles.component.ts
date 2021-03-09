import { Component, OnInit,ViewChild } from '@angular/core';
import { Role } from 'src/app/app.models';
import { MatPaginator } from '@angular/material/paginator'; 
import { MatSnackBar } from '@angular/material/snack-bar';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table'; 
import { AppService } from 'src/app/app.service';
import { RoleDialogComponent } from './role-dialog/role-dialog.component';
import { UserManagemntService } from '../user-managemnt.service';
import { MatDialog } from '@angular/material/dialog';

@Component({
  selector: 'app-roles',
  templateUrl: './roles.component.html',
  styleUrls: ['./roles.component.scss']
})
export class RolesComponent implements OnInit {

  displayedColumns: string[] = ['id', 'name', 'edit'];
  dataSource: MatTableDataSource<Role>;
  @ViewChild(MatPaginator, {static: true}) paginator: MatPaginator;
  @ViewChild(MatSort, {static: true}) sort: MatSort;
  public roles : Role[];

  constructor(public appService:AppService,
    public userManagemntService:UserManagemntService,
     public snackBar: MatSnackBar,
     public dialog: MatDialog) { }

  ngOnInit(): void {
    this.getRolesList();
  }

  getRolesList(){
  this.userManagemntService.getRolesList().subscribe((response) => {
   this.roles = <Role[]>response;
    this.initDataSource(this.roles); 
  })
 }

  public initDataSource(data:any){
    this.dataSource = new MatTableDataSource(data);
    this.dataSource.paginator = this.paginator;
    this.dataSource.sort = this.sort; 
  } 

  public addRole(role: Role){
    debugger;
    this.userManagemntService.createRole(role).subscribe( response => {
      if(response){
        this.getRolesList();
      }
    });
  }

  public updataRole(role){
    this.userManagemntService.editRole(role).subscribe(response => {
      if(response){
        this.getRolesList();
      }
    })
  }

  // public remove(role:Role) {
  //   // this.userManagemntService.deleteGroup(role.id).subscribe((response) => {
  //   //   if(response === true){
  //   //     const index = this.groups.indexOf(group, 0);
  //   //     if(index > -1){
  //   //       this.groups.splice(index, 1);
  //   //     }
  //   //   } else { alert("Som Thing Bad Happen !");}
  //   // }) 
  // }
    
  public openRoleDialog(role:Role){
      let dialogRef = this.dialog.open(RoleDialogComponent, {
        data: role
      });

      dialogRef.afterClosed().subscribe(role => {
        
        if(role){
          (role.id) ? this.updataRole(role) : this.addRole(role);
        }
      });
  }
  

  // public openRoleDialog(role:Role){
  //   debugger
  //   let message = '';   
  //    let dialogRef = this.appService.openDialog(RoleDialogComponent, role, 'theme-dialog');
  //   dialogRef.afterClosed().subscribe(rol => {  
  //     if(rol){
        
  //       this.userManagemntService.editRole(role).subscribe((roles:Role)=>{
  //         message = 'Role '+rol.name+' updated successfully';
  //         this.getRolesList();
  //       });   
  //       // const index: string = this.dataSource.data.findIndex(x => x.id == rol.id); 
  //       // if(index !== null){
  //       //   this.dataSource.data[index] = rol;
          
  //       } 
  //       else{ 
  //         let last_Role = this.dataSource.data[this.dataSource.data.length - 1]; 
  //         this.userManagemntService.createRole(rol).subscribe(()=>{
  //           message = 'New Role '+rol.name+' added successfully!'; 
  //           this.getRolesList();
  //         });
  //         // rol.id = last_Role.id + 1; 
  //         // this.dataSource.data.push(rol); 
  //         this.paginator.lastPage();
  //       }  
  //      // this.initDataSource(this.dataSource.data); 
  //       this.snackBar.open(message, '×', { panelClass: 'success', verticalPosition: 'top', duration: 30000 });          
  //     });  
  // }
}

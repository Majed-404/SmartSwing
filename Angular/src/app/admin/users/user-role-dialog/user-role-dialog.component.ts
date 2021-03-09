import { Component, Inject, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { UserRole } from 'src/app/app.models';
import { UserManagemntService } from '../../menu-items/user-managemnt.service';
import { UsersService } from '../users.service';
import { AppUsersService } from '../_services/app.users.service';

@Component({
  selector: 'app-user-role-dialog',
  templateUrl: './user-role-dialog.component.html',
  styleUrls: ['./user-role-dialog.component.scss'],
  providers: [UsersService, AppUsersService]
})
export class UserRoleDialogComponent implements OnInit {
  public form: FormGroup;
  constructor(public dialogRef: MatDialogRef<UserRoleDialogComponent>,
    @Inject(MAT_DIALOG_DATA) public userRole: UserRole,
    public fb: FormBuilder, 
    @Inject(MAT_DIALOG_DATA) public userId: string,
    public userManagementService: UserManagemntService,
    public usersService: UsersService) { }

  ngOnInit(): void { 
    debugger
    this.userManagementService.getRolesList().subscribe(response=>{

      this.userRole=response;
    });

    this.form = this.fb.group({
      id: 0,
      roleId:[0, Validators.required],
    }); 

    if(this.userRole){
      this.form.patchValue(this.userRole); 
    };
  }


  public onSubmit(){ 
    debugger
    if(this.form.valid){
      let userRoleObj:UserRole={
        userId:this.userId,
        roleId:this.form.value.roleId
      }
      this.usersService.addUserToRole(userRoleObj)
      this.dialogRef.close(userRoleObj);
    }
  }

}

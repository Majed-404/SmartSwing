import { Component, Inject, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { UserGroup } from 'src/app/app.models';
import { UserManagemntService } from '../../menu-items/user-managemnt.service';
import { AppUser } from '../user.model';
import { UsersService } from '../users.service';
import { AppUsersService } from '../_services/app.users.service';

@Component({
  selector: 'app-user-group-dialog',
  templateUrl: './user-group-dialog.component.html',
  styleUrls: ['./user-group-dialog.component.scss'],
  providers: [UsersService, AppUsersService]
})
export class UserGroupDialogComponent implements OnInit {

  public form: FormGroup;
  //public userGroup:UserGroup[];
  constructor(public dialogRef: MatDialogRef<UserGroupDialogComponent>,
              @Inject(MAT_DIALOG_DATA) public userGroup: UserGroup,
              public fb: FormBuilder, 
              @Inject(MAT_DIALOG_DATA) public userId: string,
              public userManagementService: UserManagemntService,
              public usersService: UsersService,) { }

  ngOnInit(): void { 
    debugger
    this.userManagementService.getGroups().subscribe(response=>{

      this.userGroup=response;
    });

    this.form = this.fb.group({
      id: 0,
      groupId:[0, Validators.required],
    }); 

    if(this.userGroup){
      this.form.patchValue(this.userGroup); 
    };
  }


  public onSubmit(){ 
    debugger
    if(this.form.valid){
      let userGeoupObj:UserGroup={
        userId:this.userId,
        groupId:this.form.value.groupId
      }
      this.usersService.addUserToGroup(userGeoupObj)
      this.dialogRef.close(userGeoupObj);
    }
  }

}

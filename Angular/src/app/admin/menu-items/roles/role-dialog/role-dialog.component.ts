import { Component, Inject, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Role } from 'src/app/app.models';
import { UserManagemntService } from '../../user-managemnt.service';

@Component({
  selector: 'app-role-dialog',
  templateUrl: './role-dialog.component.html',
  styleUrls: ['./role-dialog.component.scss']
})
export class RoleDialogComponent implements OnInit {

  public form: FormGroup;
  constructor(public dialogRef: MatDialogRef<RoleDialogComponent>,
              @Inject(MAT_DIALOG_DATA) public role: Role,
              public fb: FormBuilder,
              public userManagementService: UserManagemntService) { }

  ngOnInit(): void { 
    this.form = this.fb.group({
      id: "",
      name: [null, Validators.required]
    }); 

    if(this.role){
      this.form.patchValue(this.role); 
    };
  }

  public onSubmit(){ 
    if(this.form.valid){
      this.userManagementService.createRole(this.form.value);
      this.dialogRef.close(this.form.value);
    }
  }

}

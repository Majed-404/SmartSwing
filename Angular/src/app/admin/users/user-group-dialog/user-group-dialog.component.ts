import { Component, Inject, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { UserGroup } from 'src/app/app.models';

@Component({
  selector: 'app-user-group-dialog',
  templateUrl: './user-group-dialog.component.html',
  styleUrls: ['./user-group-dialog.component.scss']
})
export class UserGroupDialogComponent implements OnInit {

  public form: FormGroup;
  constructor(public dialogRef: MatDialogRef<UserGroupDialogComponent>,
              @Inject(MAT_DIALOG_DATA) public group: UserGroup,
              public fb: FormBuilder) { }

  ngOnInit(): void { 
    this.form = this.fb.group({
      id: 0,
      name: [null, Validators.required],
      description: null 
    }); 

    if(this.group){
      this.form.patchValue(this.group); 
    };
  }

  public onSubmit(){ 
    if(this.form.valid){
      this.dialogRef.close(this.form.value);
    }
  }

}

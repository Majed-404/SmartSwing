import { G } from '@angular/cdk/keycodes';
import { Component, Inject, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Group } from 'src/app/app.models';
import { UserManagemntService } from '../../user-managemnt.service';

@Component({
  selector: 'app-group-dialog',
  templateUrl: './group-dialog.component.html',
  styleUrls: ['./group-dialog.component.scss']
})
export class GroupDialogComponent implements OnInit {
  public form: FormGroup;
  constructor(public dialogRef: MatDialogRef<GroupDialogComponent>,
              @Inject(MAT_DIALOG_DATA) public group: Group,
              public fb: FormBuilder,
              public userMangmentService: UserManagemntService) { }

  ngOnInit(): void { 
    this.form = this.fb.group({
      id: 0,
      name: [null, Validators.required]
    }); 

    if(this.group){
      this.form.patchValue(this.group); 
    };
  }

  public onSubmit(){ 
    debugger
    if(this.form.valid){
      this.userMangmentService.addGroup(this.form.value);
      this.dialogRef.close(this.form.value);
    }
  }

 

}

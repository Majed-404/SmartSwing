import { AppUser } from './../user.model';
import { Component, OnInit, Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';

@Component({
  selector: 'app-app-user-dialog',
  templateUrl: './app-user-dialog.component.html',
  styleUrls: ['./app-user-dialog.component.scss']
})
export class AppUserDialogComponent implements OnInit {
  public form: FormGroup;
  public passwordHide: boolean = true;
  constructor(public dialogRef: MatDialogRef<AppUserDialogComponent>,
    @Inject(MAT_DIALOG_DATA) public user: AppUser,
    public fb: FormBuilder) {
    this.form = this.fb.group({
      id: null,
      userName: [null, Validators.compose([Validators.required, Validators.minLength(5)])],
      password: [null, Validators.compose([Validators.required, Validators.minLength(6)])],
      email: [null, Validators.compose([Validators.required, Validators.email])],
      phoneNumber: null

    });
  }


  ngOnInit() {
    if (this.user) {
      this.form.patchValue({
        id: this.user.id,
        userName: this.user.userName,
        email: this.user.email,
        phoneNumber: this.user.phoneNumber
      });
    }
    else {
      this.user = new AppUser();
    }
  }

  close(): void {
    this.dialogRef.close();
  }

}
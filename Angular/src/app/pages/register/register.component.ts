import { UserToken } from './../../admin/users/user.model';
import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { MatSnackBar } from '@angular/material/snack-bar';
import { matchingPasswords, emailValidator } from 'src/app/theme/utils/app-validators';
import { DomSanitizer } from '@angular/platform-browser';
import { AppUsersService } from 'src/app/admin/users/_services/app.users.service';
import { UserRegiste } from 'src/app/admin/users/user.model';
import { UsersService } from 'src/app/admin/users/users.service';
import { first } from 'rxjs/operators';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.scss'],
  providers: [UsersService, AppUsersService]
})
export class RegisterComponent implements OnInit {

  public registerForm: FormGroup;
  public hide = true;
  public bgImage: any;

  constructor(public fb: FormBuilder,
    public router: Router,
    public snackBar: MatSnackBar,
    private sanitizer: DomSanitizer,
    public appUsersService: AppUsersService
  ) { }

  ngOnInit() {
    debugger;
    this.bgImage = this.sanitizer.bypassSecurityTrustStyle('url(assets/images/others/register.jpg)');
    this.registerForm = this.fb.group({
      username: ['', Validators.compose([Validators.required, Validators.minLength(6)])],
      email: ['', Validators.compose([Validators.required, emailValidator])],
      password: ['', Validators.required],
      confirmPassword: ['', Validators.required],
      receiveNewsletter: false
    }, { validator: matchingPasswords('password', 'confirmPassword') });
  }

  public onRegisterFormSubmit(): void {
    debugger;
    let registerUser: UserRegiste = {
      userName: this.registerForm.value.username,
      email: this.registerForm.value.email,
      password: this.registerForm.value.password
    }
    if (this.registerForm.valid) {

      this.appUsersService.register(registerUser).subscribe((response: any) => {
        if (response) {
          localStorage.clear();
          localStorage.setItem('token', 'Bearer ' + (response as UserToken).token);
          this.router.navigate(['/login']);
        }

        // },
        // (error: any) => {
        //   alert("some thing bad is happen");
        //   console.log(error)
      });
      // this.appUsersService.register(registerUser)
      // .pipe(first())
      // .subscribe({ 
      //   next: () => {
      //     this.snackBar.open('You registered successfully!', '×', { panelClass: 'success', verticalPosition: 'top', duration: 3000 });
      //       this.router.navigate(['/login']);
      //   },
      //   error: error => {
      //     alert("some thing bad is happen");
      //     console.log(error);
      //   }
      // });
    }
  }

}

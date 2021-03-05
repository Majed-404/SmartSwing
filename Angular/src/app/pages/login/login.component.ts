import { UserToken } from './../../admin/users/user.model';
import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { DomSanitizer } from '@angular/platform-browser';
import { Router } from '@angular/router';
import { UserLogin } from 'src/app/admin/users/user.model';
import { UsersService } from 'src/app/admin/users/users.service';
import { AppUsersService } from 'src/app/admin/users/_services/app.users.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss'],
  providers: [UsersService, AppUsersService]
})
export class LoginComponent implements OnInit {
  public loginForm: FormGroup;
  public hide = true;
  public bgImage: any;


  constructor(public fb: FormBuilder,
    public router: Router,
    private sanitizer: DomSanitizer,
    private appUsersService: AppUsersService) { }

  ngOnInit(): void {
    this.bgImage = this.sanitizer.bypassSecurityTrustStyle('url(assets/images/others/login.jpg)');
    this.loginForm = this.fb.group({
      email: [null, Validators.compose([Validators.required, Validators.minLength(6)])],
      password: [null, Validators.compose([Validators.required, Validators.minLength(6)])],
      rememberMe: false
    });
  }

  public onLoginFormSubmit(): void {
    let loginUser: UserLogin = {
      email: this.loginForm.value.email,
      password: this.loginForm.value.password
    };
    if (this.loginForm.valid) {
      console.log(this.loginForm.value);
      this.appUsersService.login(loginUser).subscribe(response => {
        if (response) {
          localStorage.clear();
          localStorage.setItem('token', 'Bearer ' + (response as UserToken).token);
          this.router.navigate(['/']);
        }
      })

    }
  }

}

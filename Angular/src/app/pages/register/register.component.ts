import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators} from '@angular/forms';
import { Router } from '@angular/router'; 
import { MatSnackBar } from '@angular/material/snack-bar';
import { matchingPasswords, emailValidator } from 'src/app/theme/utils/app-validators';
import { DomSanitizer } from '@angular/platform-browser';
import { RegisterService } from './services/register.service';
import { User } from './user.model';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.scss']
})
export class RegisterComponent implements OnInit {
  public registerForm: FormGroup;
  public hide = true; 
  public bgImage:any;
  public user: User;
  constructor(public fb: FormBuilder, public router:Router, public snackBar: MatSnackBar,
     private sanitizer:DomSanitizer, private registerservice: RegisterService) { }

  ngOnInit() {
    this.bgImage = this.sanitizer.bypassSecurityTrustStyle('url(assets/images/others/register.jpg)');
    this.registerForm = this.fb.group({ 
      //username: ['', Validators.compose([Validators.required, Validators.minLength(6)])],
      email: ['', Validators.compose([Validators.required, emailValidator])],
      password: ['', Validators.required],
      confirmPassword: ['', Validators.required],
      receiveNewsletter: false                            
    },{validator: matchingPasswords('password', 'confirmPassword')});
  }
//   public addUser(user: User) {
//     this.usersService.addUser(user).subscribe(user => this.getUsers());
// }
  public onRegisterFormSubmit():void {
    if (this.registerForm.valid) {
      console.log(this.registerForm.value);
      this.snackBar.open('You registered successfully!', '×',
       { panelClass: 'success', verticalPosition: 'top', duration: 3000 });

      this.registerservice.register(this.user).subscribe(user =>{
      this.router.navigate(["./login"]);
      });
    }
  }
}

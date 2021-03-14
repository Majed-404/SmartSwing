import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { Group } from 'src/app/app.models';
import { UserManagemntService } from '../../menu-items/user-managemnt.service';

@Component({
  selector: 'app-add-mails',
  templateUrl: './add-mails.component.html',
  styleUrls: ['./add-mails.component.scss']
})
export class AddMailsComponent implements OnInit {
  public mailsForm: FormGroup;
  public groups:Group[];

  constructor(public userManagementService:UserManagemntService,
    public fb: FormBuilder,
    public router: Router) { }

  ngOnInit(): void {
    this.userManagementService.getGroups().subscribe(response=>{
      this.groups=<Group[]>response;

    });
    this.mailsForm = this.fb.group({
      id: 0,
      subject: [null, Validators.required],
      attachment:[null],
      body:[null],
      groupId:[null],

    });
  }

  

  onSubmit(){
    debugger
    console.log(this.mailsForm.value)
    if(this.mailsForm.valid){
       this.userManagementService.addAdminMails(this.mailsForm.value).subscribe(response=>{
       this.router.navigate(['admin/reviews']);
       });
    }
  }
}

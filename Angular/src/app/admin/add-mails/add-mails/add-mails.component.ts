import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Params, Router } from '@angular/router';
import { Group } from 'src/app/app.models';
import { UserManagemntService } from '../../menu-items/user-managemnt.service';
import { AdminMails } from '../../reviews/reviews';

@Component({
  selector: 'app-add-mails',
  templateUrl: './add-mails.component.html',
  styleUrls: ['./add-mails.component.scss']
})
export class AddMailsComponent implements OnInit {
  public mailsForm: FormGroup;
  public groups:Group[];
  public listGroups: Group[];
  public myParam: AdminMails;
  public id:number;
  public isAddMode=true;

  constructor(public userManagementService:UserManagemntService,
    public fb: FormBuilder,
    public router: Router,
    private route: ActivatedRoute) { }

  ngOnInit(): void {
    this.userManagementService.getGroups().subscribe(response=>{
      this.groups=<Group[]>response;});

    this.mailsForm = this.fb.group({
      id: 0,
      subject: [null, Validators.required],
      attachment:[null],
      body:[null],
      groupId:[null],
      testMail:[null]
    });

    this.userManagementService.getListUserGroups().subscribe(response => {
      this.listGroups = <Group[]>response;});  
      
      this.id = this.route.snapshot.params['id'];
      this.isAddMode = !this.id;
      if (!this.isAddMode) {
     
        this.userManagementService.getAdminMailsById(this.id)
           
            .subscribe(x => this.mailsForm.patchValue(x));
    }
  }


  onSubmit(){
    if(this.mailsForm.valid){
      if(!this.id){
        this.userManagementService.addAdminMails(this.mailsForm.value).subscribe(response=>{
          this.router.navigate(['admin/reviews']);
          });
      }
      else{
        debugger
        this.userManagementService.editAdminMails(this.id,this.mailsForm.value).subscribe(response=>{
          this.router.navigate(['admin/reviews']);
          });
      }
    }
  }

  public editMail(){

    if(this.mailsForm.valid){
      this.userManagementService.editAdminMails(this.id,this.mailsForm.value).subscribe(response=>{
        this.router.navigate(['admin/reviews']);
        });
    }
  }


  public saveCopy(){

    if(this.mailsForm.valid){
     
        this.userManagementService.addAdminMails(this.mailsForm.value).subscribe(response=>{
          this.router.navigate(['admin/reviews']);
          });

    }

  }
}

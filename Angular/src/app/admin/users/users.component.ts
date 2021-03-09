import { AppUserDialogComponent } from './app-user-dialog/app-user-dialog.component';
import { Component, OnInit, ViewEncapsulation } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { AppSettings, Settings } from '../../app.settings';
import { User, AppUser, UserProfile, UserWork, UserContacts, UserSocial, UserSettings } from './user.model';
import { UsersService } from './users.service';
import { UserDialogComponent } from './user-dialog/user-dialog.component';
import { AppUsersService } from './_services/app.users.service';
import { response } from 'express';
import { UserGroupDialogComponent } from './user-group-dialog/user-group-dialog.component';
import { UserManagemntService } from '../menu-items/user-managemnt.service';
import { UserGroup } from 'src/app/app.models';

@Component({
    selector: 'app-users',
    templateUrl: './users.component.html',
    styleUrls: ['./users.component.scss'],
    encapsulation: ViewEncapsulation.None,
    providers: [UsersService, AppUsersService]
})
export class UsersComponent implements OnInit {
    uss: any;
    public users: User[];
    public appUsers: AppUser[];
    public searchText: string;
    public page: any;
    public settings: Settings;
    constructor(public appSettings: AppSettings,
        public dialog: MatDialog,
        public usersService: UsersService,
        public appUsersService: AppUsersService) {
        this.settings = this.appSettings.settings;
    }

    ngOnInit() {
        //this.getUsers();     
        this.getUsersList();
    }

    public getUsersList(): void {

        this.appUsers = null; //for show spinner each time
        this.appUsersService.getUsersList().subscribe(response => {
            this.appUsers = <AppUser[]>response;
        },
            error => {
                alert("some thing bad is happen");
                console.log(error);
            });
    }

    public getUsers(): void {
        this.users = null; //for show spinner each time
        this.usersService.getUsers().subscribe(users => this.users = users);
    }

    public addUser(user: AppUser) {
        this.appUsersService.addUser(user).subscribe(response=>{
            if(response){
                this.getUsersList();
            }
        });
    }

    public updateUser(user: AppUser) {
        this.appUsersService.updateUser(user).subscribe(response=>{
            if(response){
                this.getUsersList();
            }
        });
    }
    public deleteUser(user: AppUser) {
        this.appUsersService.deleteUser(user.id).subscribe(response => {
            if (response === true) {
                const index = this.appUsers.indexOf(user, 0);
                if (index > -1) {
                    this.appUsers.splice(index, 1);
                }
            } else {
                alert("Some Thing Bad Happen !");
            }
        });
    }


    public onPageChanged(event) {
        this.page = event;
        this.getUsersList();
        window.scrollTo(0, 0);
        // if(this.settings.fixedHeader){      
        //     document.getElementById('main-content').scrollTop = 0;
        // }
        // else{
        //     document.getElementsByClassName('mat-drawer-content')[0].scrollTop = 0;
        // }
    }

    public addUserGroup(usergroup: UserGroup){
        this.usersService.addUserToGroup(usergroup).subscribe(response => {

            if(response){
                this.getUsersList();
            }
        });
    }

    public openUserDialog(user) {
        let dialogRef = this.dialog.open(AppUserDialogComponent, {
            data: user
        });

        dialogRef.afterClosed().subscribe(user => {
            
            if (user) {
                (user.id) ? this.updateUser(user) : this.addUser(user);
            }
        });
      
    }

    public openUserGroupDialog(user){

        let dialogRef = this.dialog.open(UserGroupDialogComponent, {
            data: user
        });

        dialogRef.afterClosed().subscribe(userGroup=> {
            
                this.addUserGroup(userGroup);
            
        });
    }

}
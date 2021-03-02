import { Component, OnInit, ViewEncapsulation } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { AppSettings, Settings } from '../../app.settings';
import { User, AppUser, UserProfile, UserWork, UserContacts, UserSocial, UserSettings } from './user.model';
import { UsersService } from './users.service';
import { UserDialogComponent } from './user-dialog/user-dialog.component';
import { AppUsersService } from './_services/app.users.service';

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
    public addUser(user: User) {
        this.usersService.addUser(user).subscribe(user => this.getUsers());
    }
    public updateUser(user: User) {
        this.usersService.updateUser(user).subscribe(user => this.getUsers());
    }
    public deleteUser(user: User) {
        this.usersService.deleteUser(user.id).subscribe(user => this.getUsers());
    }


    public onPageChanged(event) {
        this.page = event;
        this.getUsers();
        window.scrollTo(0, 0);
        // if(this.settings.fixedHeader){      
        //     document.getElementById('main-content').scrollTop = 0;
        // }
        // else{
        //     document.getElementsByClassName('mat-drawer-content')[0].scrollTop = 0;
        // }
    }

    public openUserDialog(user) {
        let dialogRef = this.dialog.open(UserDialogComponent, {
            data: user
        });

        dialogRef.afterClosed().subscribe(user => {
            if (user) {
                (user.id) ? this.updateUser(user) : this.addUser(user);
            }
        });
    }

}
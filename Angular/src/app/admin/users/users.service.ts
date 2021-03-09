import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { User, AppUser, UserRegiste } from './user.model';
import { UserGroup, UserRole } from 'src/app/app.models';

@Injectable()
export class UsersService {
    public url = "api/users";
    public apiUrl = "http://localhost:49974/api/Auth/";
    public groupApiUrl = "http://localhost:49974/api/"
    constructor(public http: HttpClient) { }

    getUsers(): Observable<User[]> {
        return this.http.get<User[]>(this.url);
    }

    getUsersList(): Observable<any> {
        return this.http.get(this.apiUrl + "UsersList");
    }

    addUser(user: User) {
        return this.http.post(this.url, user);
    }

    updateUser(user: User) {
        return this.http.put(this.url, user);
    }

    deleteUser(id: number) {
        return this.http.delete(this.url + "/" + id);
    }

    public addUserToGroup(userGroup: UserGroup){
        return this.http.post(this.groupApiUrl+"Groups/AddUserToGroup", userGroup)
      }
    // register(user: UserRegiste): Observable<any>{
    //     return this.http.post(this.apiUrl+"Register", user);
    //  }
    public addUserToRole(userRole: UserRole){
        return this.http.post(this.groupApiUrl+"User/AddUserToRloe", userRole)
      }
     
} 
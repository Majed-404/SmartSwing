import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { UserLogin, UserRegiste } from '../user.model';

@Injectable()
export class AppUsersService {
    public url = "api/users";
    public apiUrl = "http://localhost:49974/api/Auth/"
    constructor(public http: HttpClient) { }

    getUsersList(): Observable<any> {
        return this.http.get(this.apiUrl + "UsersList");
    }

    register(user: UserRegiste): Observable<any>{
       return this.http.post(this.apiUrl+"Register", user);
    }

    login(user: UserLogin){

        return this.http.get(this.apiUrl+ "login")
    }

} 
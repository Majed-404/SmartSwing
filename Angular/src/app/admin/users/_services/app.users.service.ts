import { AppUser } from './../user.model';
import { environment } from 'src/environments/environment';
import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { UserLogin, UserRegiste } from '../user.model';

@Injectable()
export class AppUsersService {
    public apiUrl = environment.apiUrl + "user/"
    public authApiUrl = environment.apiUrl + "auth/"

    httpOptions = {
        headers: new HttpHeaders({
            'Content-Type': 'application/json',
            'Authorization': localStorage.getItem('token')
        })
    };

    constructor(public http: HttpClient) { }

    getUsersList(): Observable<any> {
        return this.http.get(this.apiUrl + "get", this.httpOptions);
    }

    getUser(id: string): Observable<any> {
        return this.http.get(this.apiUrl + "get/" + id, this.httpOptions);
    }

    deleteUser(id: string): Observable<any> {
        return this.http.delete(this.apiUrl + "delete/" + id, this.httpOptions);
    }

    updateUser(user: AppUser): Observable<any> {
        return this.http.put(this.apiUrl + "update/" + user.id, user, this.httpOptions);
    }

    addUser(user: AppUser): Observable<any> {
        return this.http.post(this.apiUrl + "create", user, this.httpOptions);
    }


    register(user: UserRegiste): Observable<any> {
        return this.http.post(this.authApiUrl + "register", user);
    }

    login(user: UserLogin): Observable<any> {
        return this.http.post(this.authApiUrl + "login", user);
    }
}
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable()
export class AppUsersService {
    public url = "api/users";
    public apiUrl = "http://localhost:49974/api/Auth/"
    constructor(public http: HttpClient) { }

    getUsersList(): Observable<any> {
        return this.http.get(this.apiUrl + "UsersList");
    }

} 
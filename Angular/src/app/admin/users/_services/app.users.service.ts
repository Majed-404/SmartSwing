import { AppUser } from './../user.model';
import { environment } from 'src/environments/environment';
import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable()
export class AppUsersService {
    public apiUrl = environment.apiUrl + "user/"

    httpOptions = {
        headers: new HttpHeaders({
            'Content-Type': 'application/json',
            'Authorization': 'Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOlsibWFqZWQyQGdtYWlsLmNvbSIsIm1hamVkMkBnbWFpbC5jb20iXSwianRpIjoiYzUzYzE3MzUtZWQ5MC00Nzc5LWI4YjQtMDk4MDhhMzgyNmYyIiwiZXhwIjoxNjE0OTYzNDQ5LCJpc3MiOiJNYWplZCIsImF1ZCI6Ik1hamVkIn0.smaBGDnhp78awWmgIZpLkNqynvIvb8O2kXXh8WjVGV4'
        })
    };

    constructor(public http: HttpClient) { }

    getUsersList(): Observable<any> {
        return this.http.get(this.apiUrl + "get", this.httpOptions);
    }

    getUser(id: string): Observable<any>{
        return this.http.get(this.apiUrl + "get/" + id, this.httpOptions);
    }

    deleteUser(id: string): Observable<any>{
        return this.http.delete(this.apiUrl + "delete/" + id, this.httpOptions);
    }

    updateUser(user: AppUser): Observable<any>{
        return this.http.put(this.apiUrl + "update/"+ user.id, user, this.httpOptions);
    }

    addUser(user: AppUser): Observable<any>{
        return this.http.post(this.apiUrl + "create", user, this.httpOptions);
    }
} 
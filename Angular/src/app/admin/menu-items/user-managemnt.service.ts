import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Role } from 'src/app/app.models';
@Injectable({
  providedIn: 'root'
})
export class UserManagemntService {

  constructor(public http:HttpClient) { }
  public apiUrl = "http://localhost:49974/api/"
  public getRolesList(): Observable<any> {
    return this.http.get(this.apiUrl + "Auth/ListRoles");
  }
  public createRole(role:Role): Observable<any> {
    return this.http.post(this.apiUrl + "Auth/CreateRole",role);
  }

  public editRole(role:Role): Observable<any> {
    return this.http.post(this.apiUrl + "Auth/EditRole",role);
  }
  public getGroups(): Observable<any> {
    return this.http.get(this.apiUrl + "Groups/ListGroups");
  }
}

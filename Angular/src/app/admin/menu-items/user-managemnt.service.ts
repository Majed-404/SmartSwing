import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Group, Role } from 'src/app/app.models';
import { AdminMails } from '../reviews/reviews';

// const httpOptionsPlain = {
//   headers: new HttpHeaders({
//     'Accept': 'text/plain',
//     'Content-Type': 'text/plain'
//   }),
//   'responseType': 'text'
// };



@Injectable({
  providedIn: 'root'
})
export class UserManagemntService {

  constructor(public http:HttpClient) { }

  public apiUrl = "http://localhost:49974/api/";

  httpOptions = {
    headers: new HttpHeaders({
        'Content-Type': 'application/json',
        'Authorization': localStorage.getItem('token')
    })
  };

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

  public addGroup(group: Group){
    return this.http.post(this.apiUrl + "Groups/CreateGroup", group, this.httpOptions);
  }
  updateGroup(group: Group): Observable<any> {
    return this.http.put(this.apiUrl + "Groups/EditGroup", group);
}
public getAdminMails(): Observable<any> {
  return this.http.get(this.apiUrl + "AdminMails/ListAdminMails");
}
public addAdminMails(mail:AdminMails): Observable<any> {
  return this.http.post(this.apiUrl + "AdminMails/CreateAdminMail",mail);
}

public deleteGroup(id: number){
  return this.http.delete(this.apiUrl+"Groups/Delete?Id="+id)
}

public editGroup(group: Group){
  return this.http.put(this.apiUrl+"Groups/EditGroup", group)
}
}

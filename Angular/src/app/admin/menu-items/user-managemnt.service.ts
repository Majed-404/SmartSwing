import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Group, Role, UserGroup } from 'src/app/app.models';
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


  httpOptions = {
    headers: new HttpHeaders({
        'Content-Type': 'application/json',
        'Authorization': localStorage.getItem('token')
    })
 };

  constructor(public http:HttpClient) { }

  public apiUrl = "http://localhost:49974/api/";

 
  public getRolesList(): Observable<any> {
    return this.http.get(this.apiUrl + "Auth/ListRoles", this.httpOptions);
  }

  public createRole(role:Role): Observable<any> {
    
    return this.http.post(this.apiUrl + "Auth/CreateRole", role,this.httpOptions);
  }

  public editRole(role:Role): Observable<any> {
    return this.http.put(this.apiUrl + "Auth/EditRole", role, this.httpOptions);
  }


  public getGroups(): Observable<any> {
    return this.http.get(this.apiUrl + "Groups/ListGroups", this.httpOptions);
  }

  public addGroup(group: Group){
    return this.http.post(this.apiUrl + "Groups/CreateGroup", group, this.httpOptions);
  }

  public updateGroup(group: Group): Observable<any> {
    return this.http.put(this.apiUrl + "Groups/EditGroup", group, this.httpOptions);
  }

  public deleteGroup(id: number){
  return this.http.delete(this.apiUrl+"Groups/Delete?Id="+id, this.httpOptions)
  }

  public editGroup(group: Group){
  return this.http.put(this.apiUrl+"Groups/EditGroup", group, this.httpOptions)
  }
  
  public getAdminMails(): Observable<any> {
  return this.http.get(this.apiUrl + "AdminMails/ListAdminMails", this.httpOptions);
  }
  public getAdminMailsById(id): Observable<any> {
    return this.http.get(this.apiUrl + "AdminMails/GetAdminMailById/"+id, this.httpOptions);
    }
  public addAdminMails(mail:AdminMails): Observable<any> {
  return this.http.post(this.apiUrl + "AdminMails/CreateAdminMail", mail , this.httpOptions);
  }
  public editAdminMails(id:number,mail:AdminMails): Observable<any> {
    return this.http.post(this.apiUrl + "AdminMails/EditAdminMail/"+id, mail , this.httpOptions);
    }
 public getListUserGroups(){
   return this.http.get(this.apiUrl+"Groups/ListUserGroups", this.httpOptions)
 }

  
}

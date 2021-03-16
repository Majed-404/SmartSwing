import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { AdminMails } from '../reviews';

@Injectable({
  providedIn: 'root'
})
export class AdminMailService {

  httpOptions = {
    headers: new HttpHeaders({
        'Content-Type': 'application/json',
        'Authorization': localStorage.getItem('token')
    })
 };

  constructor(public http:HttpClient) { }

  public apiUrl = "http://localhost:49974/api/";

  public deleteMail(id: number){
    return this.http.delete(this.apiUrl+"AdminMails/Delete?Id="+id, this.httpOptions)
  }

  public editMail(mail: AdminMails){

    return this.http.put(this.apiUrl+"AdminMails/EditAdminMail", this.httpOptions)
  }

  public sendMail(id: number, isTest: boolean){

    return this.http.post(this.apiUrl+"AdminMails/SendMail",this.httpOptions)
  }


}

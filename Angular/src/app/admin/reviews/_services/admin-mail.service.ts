import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';

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
}

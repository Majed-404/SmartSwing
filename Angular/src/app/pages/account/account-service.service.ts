import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AccountService {
  httpOptions = {
    headers: new HttpHeaders({
        'Content-Type': 'application/json',
        'Authorization': localStorage.getItem('token')
    })
 };
  constructor(public http:HttpClient) { }
  public apiUrl = "http://localhost:49974/api/";

  public getMarketsList(): Observable<any> {
    return this.http.get(this.apiUrl + "Markets/MarketList", this.httpOptions);
  }

}

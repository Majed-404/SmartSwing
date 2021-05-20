import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Injectable } from "@angular/core";

@Injectable({
    providedIn: 'root'
  })
export class VisitorMarketService{
    httpOptions = {
        headers: new HttpHeaders({
            'Content-Type': 'application/json',
            'Authorization': localStorage.getItem('token')
        })
     };
    
      constructor(public http:HttpClient) { }
    
      public apiUrl = "http://localhost:49974/api/";


      public getVisitorStocks(id: number){
        return this.http.get(this.apiUrl+"Markets/StockListExchange/"+id, this.httpOptions)
        }
      
}
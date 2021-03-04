import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from 'express';
import { Observable } from 'rxjs';
import { User } from '../user.model';

@Injectable({
  providedIn: 'root'
})
export class RegisterService {


  constructor(private httpClient: HttpClient, private router:Router) {

   }

   register(user: User) {
    return this.httpClient.post("http://localhost:49974/api/Auth/Register", user);
   }

}

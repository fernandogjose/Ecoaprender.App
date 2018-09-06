import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment';
import { HttpClient } from '@angular/common/http';
import { LoginRequest } from './loginRequest.dto';

@Injectable({
  providedIn: 'root'
})
export class LoginService {

  constructor(public http: HttpClient) { }

  login(loginRequest: LoginRequest) {
    return this.http.get(`${environment.baseUrlApi}/user/login/${loginRequest.email}/${loginRequest.password}`);
  }
}

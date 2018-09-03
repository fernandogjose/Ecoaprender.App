import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment';
import { HttpClient } from '@angular/common/http';
import { UserLoginRequest } from '../dtos/userLoginRequest';

@Injectable({
  providedIn: 'root'
})
export class LoginService {

  constructor(public http: HttpClient) { }

  login (userLoginRequest: UserLoginRequest) {
    return this.http.get(`${environment.baseUrlApi}/user/login/${userLoginRequest.email}/${userLoginRequest.password}`);
  }

}

import { Component, OnInit } from '@angular/core';
import { UserLoginRequest } from '../dtos/userLoginRequest';
import { MenuController } from '@ionic/angular';
import { UserLoginResponse } from '../dtos/UserLoginResponse';
import { LoginService } from './login.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.page.html',
  styleUrls: ['./login.page.scss'],
})
export class LoginPage implements OnInit {

  public userLoginRequest = new UserLoginRequest('', '');

  constructor(
    public menu: MenuController,
    public loginService: LoginService
  ) {
    this.menu = menu;
    this.menu.enable(false);
  }

  public login(): void {
    this.loginService
      .login(this.userLoginRequest)
      .subscribe((userLoginResponse: UserLoginResponse) => {

      }, error => {

      });
  }

  ngOnInit() {
  }
}
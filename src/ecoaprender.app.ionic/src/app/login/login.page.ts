import { Component, OnInit } from '@angular/core';
import { LoginRequest } from './loginRequest.dto';
import { MenuController, NavController } from '@ionic/angular';
import { LoginResponse } from './loginResponse.dto';
import { LoginService } from './login.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.page.html',
  styleUrls: ['./login.page.scss'],
})
export class LoginPage implements OnInit {

  public loginRequest = new LoginRequest('', '');

  constructor(
    public menuController: MenuController,
    public loginService: LoginService,
    private navController: NavController
  ) {
    this.menuController.enable(false);
  }

  public login(): void {
    this.navController.navigateForward('/home')

    // this.loginService
    //   .login(this.loginRequest)
    //   .subscribe((loginResponse: LoginResponse) => {

    //   }, error => {

    //   });
  }

  ngOnInit() {
  }
}
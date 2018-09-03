
import { Component } from '@angular/core';
import { UserLoginRequest } from '../dtos/userLoginRequest';
import { MenuController } from '@ionic/angular';
import { UserService } from '../services/user.service';
import { UserLoginResponse } from '../dtos/UserLoginResponse';

@Component({
  selector: 'app-home',
  templateUrl: 'home.page.html',
  styleUrls: ['home.page.scss'],
})

export class HomePage {

  public userLoginRequest = new UserLoginRequest('', '');

  constructor(
    public menu: MenuController,
    public userService: UserService
  ) {
    this.menu = menu;
    this.menu.enable(false);
  }

  public login(): void {
    this.userService
      .login(this.userLoginRequest)
      .subscribe((userLoginResponse: UserLoginResponse) => {

      }, error => {

      });
  }
}

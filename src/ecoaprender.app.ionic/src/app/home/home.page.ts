import { Component, OnInit } from '@angular/core';
import { SharedService } from '../app.shared.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.page.html',
  styleUrls: ['./home.page.scss'],
})
export class HomePage implements OnInit {

  private sharedService: SharedService;

  constructor() {
    this.sharedService = SharedService.getInstance();
   }

  ngOnInit() {
    this.sharedService.setUsername('Fernando José');
  }

  public changeUsername(): void{
    this.sharedService.setUsername('Gabriel Antunes');
  }

}

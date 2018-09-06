import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})

export class SharedService {

  public static instance: SharedService = null;
  public username: string;

  constructor() { 
    return SharedService.instance = SharedService.instance || this;
  }

  public static getInstance() {
    if (this.instance == null){
      this.instance = new SharedService();
    }

    return this.instance;
  }

  public getUsername(): string {
    return this.username;
  }

  public setUsername(username): void {
    this.username = username;
  }
}

import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  constructor() { }
  // Checks if the User is Logged in
  IsLoggedIn() {
    return !!localStorage.getItem("token")
  }
  // Checks if the User is Logged out
  IsLoggedOut() {
    return !(!!localStorage.getItem("token"))
  }

  // Gets the Current Token
  getToken() {
    return localStorage.getItem("token")
  }
}

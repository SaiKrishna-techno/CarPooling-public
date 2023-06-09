import {
  HttpEvent,
  HttpHandler,
  HttpInterceptor,
  HttpRequest,
  HttpClient,
  HttpResponse
} from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, tap } from 'rxjs';
import { AuthService } from '../services/auth.service';
import * as Notiflix from 'notiflix';
import { Router } from '@angular/router';
@Injectable({
  providedIn: 'root',
})
export class TokeninterceptorService implements HttpInterceptor {
  constructor(private auth: AuthService,  private router: Router,) {}

  // Getting  the value of the Token 
  token = this.auth.getToken();

  intercept(
    
    req: HttpRequest<any>,
    next: HttpHandler
  ): Observable<HttpEvent<any>> {
    //Checking if the Token Exists and adding the header if it exists
    if (this.token) {
      Notiflix.Loading.dots("Loading");
      let currentDate= new Date();
      let tokenExpiryTimeInSeconds : number =+localStorage.getItem('tokenExpiryTime')!
      let tokenExipryTime= new Date (tokenExpiryTimeInSeconds * 1000)
      if(currentDate>tokenExipryTime){
        localStorage.clear()
        this.router.navigate(['/login'])
      }
      req = req.clone({
        setHeaders: { Authorization: `bearer ${this.token.slice(1,-1)}` },
      });
    }
    //return next.handle(req);
    return next.handle(req).pipe(
      tap({
        next: (event : any) => {
          // if (event instanceof HttpResponse) {
            // if(event.status == 401) {
            //   alert('Unauthorized access!')
            // }
          // }
          Notiflix.Loading.remove(3000);
          return event;
        },
        // error: (error : any) => {
        //   if(error.status==401){
        //     alert("Unauthorized Access!")
        //   }

        //   else if(error.status === 404) {
        //     alert('Page Not Found!')
        //     Notiflix.Loading.remove(3000);
        //   }
        // }
      }));
    
  }
  
}

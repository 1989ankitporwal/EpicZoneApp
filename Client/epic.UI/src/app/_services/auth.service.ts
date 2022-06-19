import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpResponse } from '@angular/common/http';
import { Router } from '@angular/router';
import { environment } from 'src/environments/environment';
import { UtilService } from './util.service';
import { AUTH_AToken, AUTH_ID, AUTH_LoginStatus, AUTH_RToken } from '../app.constant';
import { Observable } from 'rxjs';
import { User } from '../_models/User';

@Injectable({
  providedIn: 'root'
})

export class AuthService {
  user: User;
  readonly apiUrl = environment.apiUrl + '/Account/';
  httpHeaders:HttpHeaders;

  constructor(private http: HttpClient, private utilService: UtilService, private router: Router) {
    this.httpHeaders = new HttpHeaders({'content-type': 'application/json'});
    this.user = new User(0, '', '', '', '', '', false, '', '', [], []);
   }

   ValidateUser(loginUser:any): Observable<HttpResponse<User>>{
    return this.http.post<User>(this.apiUrl + 'Login/'
            , JSON.stringify(loginUser), {headers: this.httpHeaders, observe:'response'});
  }

  SetSessionStorageKey(user: User){
    sessionStorage.setItem(AUTH_AToken, user.token);
    sessionStorage.setItem(AUTH_RToken, user.refreshToken);
    let encUserData = this.utilService.Encrypt(user);
    sessionStorage.setItem(AUTH_ID, encUserData);
    sessionStorage.setItem(AUTH_LoginStatus, '1');
  }

  GetAccessToken(){
    let accessToken = sessionStorage.getItem(AUTH_AToken); 
    return accessToken;
  }

  GetRefreshToken(){
    let refreshToken = sessionStorage.getItem(AUTH_RToken); 
    return refreshToken;
  }

  GetLoginStatus(){
    let loginStatus = sessionStorage.getItem(AUTH_LoginStatus); 
    return loginStatus;
  }

  UserCheckedBasedOnKey(){
    const storageKey = sessionStorage.getItem(AUTH_AToken);
    if(storageKey === undefined || storageKey === null){
      window.location.reload();
    }
  }

  GetRefreshingTokens(token: string, refreshToken: string): Observable<HttpResponse<User>>{
    const credentials = JSON.stringify({ accessToken: token, refreshToken: refreshToken });

    return this.http.post<User>(this.apiUrl + 'Refresh/'
            , credentials, {headers: this.httpHeaders, observe:'response'});
  }

  logOut() {
    sessionStorage.removeItem(AUTH_AToken);
    sessionStorage.removeItem(AUTH_RToken);
    sessionStorage.removeItem(AUTH_ID);
    sessionStorage.removeItem(AUTH_LoginStatus);
    window.location.reload();
  }

  getLoggedInUser(): User{
    let userData: User = new User(0, '', '', '', '', '', false, '', '', [], []);
    const encUserData = sessionStorage.getItem(AUTH_ID);
    if(encUserData !== undefined && encUserData !== null){
      userData = this.utilService.Decrypt(encUserData);
    }
    return userData;
  }

  isAdmin(): boolean{
    let userData: User;
    userData = this.getLoggedInUser();
    return userData.roleIds.includes(1);
  }

  isUser(): boolean{
    let userData: User;
    userData = this.getLoggedInUser();
    return userData.roleIds.includes(2);
  }
}

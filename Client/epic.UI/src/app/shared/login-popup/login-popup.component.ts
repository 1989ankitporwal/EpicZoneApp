import { Component, EventEmitter, Inject, OnInit, Output, ViewChild } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { User } from 'src/app/_models/User';
import { AuthService } from 'src/app/_services/auth.service';

@Component({
  selector: 'app-login-popup',
  templateUrl: './login-popup.component.html',
  styles: [
  ]
})
export class LoginPopupComponent implements OnInit {
  user: User;
  //@Output() loginMessage: EventEmitter<boolean>;
  @ViewChild('email') email: any;
  @ViewChild('password') password: any;
  @ViewChild('loginForm') loginForm: any;

  //constructor(private authService: AuthService) {
  constructor(public authService: AuthService, public toastr: ToastrService) {
    //this.loginMessage = new EventEmitter<boolean>();
    this.user = new User(0, '', '', '', '', '', false, '', '', [], []);
  }

  ngOnInit(): void {
  }

  Login(loginForm: NgForm) {
    this.authService.ValidateUser(loginForm.value).subscribe(response => {
      if (response.body != null) {
        this.user = response.body;
        if (this.user != null) {
          this.authService.SetSessionStorageKey(this.user);
          debugger;
          if (this.user != undefined) {
            //this.loginMessage.emit(true);
            // if(this.authService.isAdmin()){
            //   this.router.navigate(['/admin']);
            // }
            // else{
            //   window.location.reload();
            // }
            window.location.reload();
          }
        }
      }
    });
  }

  cancel() {
    //this.loginForm.controls.userName.reset();
    //this.loginForm.controls.password.reset();
  }
}

import { Component, OnInit } from '@angular/core';
import { AuthService } from 'src/app/_services/auth.service';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styles: [
  ]
})
export class HeaderComponent implements OnInit {
  isLoggedIn: boolean;
  constructor(private authService: AuthService) {
    this.isLoggedIn = false;
   }

  ngOnInit(): void {
    this.isLoggedIn = (this.authService.GetLoginStatus() === '1') ? true: false;
  }

}

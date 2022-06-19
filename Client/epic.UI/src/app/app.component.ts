import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AuthService } from './_services/auth.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  isNormalUser: boolean = true;
  title = 'epic.UI';

  constructor(private authService: AuthService, private router: Router) {
  }

  ngOnInit(): void {
    if (this.authService.isAdmin()) {
      this.isNormalUser = false;
      //this.renderer.addClass(this.document.body, 'hold-transition skin-blue sidebar-mini');
      this.router.navigate(['/admin']);
    }
  }

  // ngOnDestroy(): void {
  //   this.renderer.removeClass(this.document.body, 'hold-transition skin-blue sidebar-mini');
  // }
}

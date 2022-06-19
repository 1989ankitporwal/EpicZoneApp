import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { AppRoutingModule } from './app-routing.module';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { ToastrModule } from 'ngx-toastr';

import { AppComponent } from './app.component';
import { LayoutComponent } from './shared/layout.component';
import { HeaderComponent } from './shared/header/header.component';
import { EventCategoryComponent } from './event-category/event-category.component';
import { EventDateSelectionComponent } from './event-date-selection/event-date-selection.component';
import { EventDetailsComponent } from './event-details/event-details.component';
import { EventCustomizeComponent } from './event-customize/event-customize.component';
import { EventFinalizeComponent } from './event-finalize/event-finalize.component';
import { LoginPopupComponent } from './shared/login-popup/login-popup.component';

@NgModule({
  declarations: [
    AppComponent,
    LayoutComponent,
    HeaderComponent,
    EventCategoryComponent,
    EventDateSelectionComponent,
    EventDetailsComponent,
    EventCustomizeComponent,
    EventFinalizeComponent,
    LoginPopupComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,
    ToastrModule.forRoot({
      positionClass: 'toast-bottom-right'
    })
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

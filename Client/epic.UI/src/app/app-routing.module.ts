import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AdminAuthGuard } from './admin-auth.guard';
import { EventCategoryComponent } from './event-category/event-category.component';
import { EventCustomizeComponent } from './event-customize/event-customize.component';
import { EventDateSelectionComponent } from './event-date-selection/event-date-selection.component';
import { EventDetailsComponent } from './event-details/event-details.component';
import { EventFinalizeComponent } from './event-finalize/event-finalize.component';
import { LayoutComponent } from './shared/layout.component';
import { UserAuthGuard } from './user-auth.guard';

const routes: Routes = [
  { path: '', component: EventCategoryComponent },
  { path: 'eventDate', component: EventDateSelectionComponent },
  { path: 'eventDetail', component: EventDetailsComponent },
  { path: 'eventCustomize', component: EventCustomizeComponent },
  { path: 'eventFinal', component: EventFinalizeComponent },
  //{ path: '', loadChildren: () => import('./public/public.module').then(m => m.PublicModule) },
  { path: 'admin', loadChildren: () => import('./admin/admin.module').then(m => m.AdminModule) },
  { path: 'user', loadChildren: () => import('./user/user.module').then(m => m.UserModule), canActivate: [UserAuthGuard] },
  //   { path: 'notfound', component: NotfoundComponent },
  { path: '**', redirectTo: '/notfound' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

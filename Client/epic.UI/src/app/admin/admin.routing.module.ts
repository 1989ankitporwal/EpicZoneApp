import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DashboardComponent } from './dashboard/dashboard.component';
import { AdminLayoutComponent } from './shared/admin-layout.component';

const routes: Routes = [
  {
    path: '', component: AdminLayoutComponent, children: [
       { path: '', component: DashboardComponent },
    //   { path: 'courses', component: CoursesComponent },
    //   { path: 'course/{id}', component: CoursesComponent }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class AdminRoutingModule { }

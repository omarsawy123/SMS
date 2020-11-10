import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule, Routes } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { StudentsListComponent } from './students/studentView/students-list.component';
import { StudentServeices } from './students/services/studentServices';
import { HomeComponent } from './Home/home.component';
import { SelectorComponent } from './Selector/selector.component';
import { StudentDetailsComponent } from './students/studentView/student-details.component';
import { AddstudentComponent } from './studentForm/addstudent.component';



const approutes:Routes=[
  {path:'home',component:HomeComponent},
  {path:'selector',component:SelectorComponent},
  {path:'students',component:StudentsListComponent},
  {path:'students/add',component:AddstudentComponent},
  {path:'students/:id',component:StudentDetailsComponent},
  {path:'',redirectTo:'/home',pathMatch:'full'},
  {path:'**',component:HomeComponent,pathMatch:'full'},

]


@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    StudentsListComponent,
    HomeComponent,
    SelectorComponent,
    StudentDetailsComponent,
    AddstudentComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    ReactiveFormsModule,
    FormsModule,
    RouterModule.forRoot(approutes)
  ],
  providers: [StudentServeices],
  bootstrap: [AppComponent]
})
export class AppModule { }

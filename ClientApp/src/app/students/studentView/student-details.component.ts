import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { IStudent } from '../models/IStudent';
import { StudentServeices } from '../services/studentServices';

@Component({
  selector: 'app-student-details',
  templateUrl: './student-details.component.html',
  styleUrls: ['./student-details.component.css']
})
export class StudentDetailsComponent implements OnInit {

  student: IStudent;

  show: boolean = false;

  constructor(private _services: StudentServeices, private _route: ActivatedRoute) { }

  ngOnInit() {


    const studId = +this._route.snapshot.paramMap.get('id');
    this._services.getStudent(studId).subscribe(data => this.student = data);

  }

  Collapse() {
    this.show = !this.show;
  }

}

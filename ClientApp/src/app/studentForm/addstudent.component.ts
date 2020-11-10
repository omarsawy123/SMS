import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { IStudent } from '../students/models/IStudent'
import { StudentServeices } from '../students/services/studentServices';

@Component({
  selector: 'app-addstudent',
  templateUrl: './addstudent.component.html',
  styleUrls: ['./addstudent.component.css']
})
export class AddstudentComponent implements OnInit {


  studentForm: FormGroup;
  student: IStudent;
  students: IStudent[];

  HeaderText = "Add Student";



  constructor(private _services: StudentServeices, private fb: FormBuilder, private _router: Router) { }

  ngOnInit() {

    this.studentForm = this.fb.group({
      nameFr: ['', [Validators.required, Validators.minLength(5)]],
      nameAr: ['', [Validators.required, Validators.minLength(5)]],
      dateOfBirth: ['', [Validators.required]],
      religionId:[''],
      locationOfBirth:[''],
      nationalityId:[''],
      remarks:[''],
      fatherName: ['', [Validators.required]],
      motherName: ['', [Validators.required]],
      telephone: ['', [Validators.required, Validators.pattern("^[0-9]*$")]]
    });

    this._services.getStudents().subscribe(data => this.students = data);
  }

  saveStudent(form) {

    this.student = form.value;
    this.student.studentId = this.students[this.students.length - 1].studentId + 1;
    this._services.postStudent(this.student).subscribe((data: IStudent) => {
      console.log(this.student),
        this.studentForm.reset(),
        this._router.navigate(['/students'])
    });

   

  }

}

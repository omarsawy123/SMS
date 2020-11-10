import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { IStudent } from "../models/IStudent";


@Injectable()

export class StudentServeices {

    constructor(private _http: HttpClient) { }

   
        // students: Students[] = [
    //     {
    //         id: 1,
    //         nameAr: "مارك عماد ",
    //         nameFr: "Mark Emad",
    //         dateOfBirth: "12/12/2020",
    //         grade: "First year",
    //         parentName: "Emad",
    //         Tel_No: ""
    //     },
    //     {
    //         id: 2,
    //         nameAr: "مايكل جرجس ",
    //         nameFr: "Michael Gerges",
    //         dateOfBirth: "12/12/2020",
    //         grade: "second year",
    //         parentName: "Gerges",
    //         Tel_No: ""

    //     },
    //     {
    //         id: 3,
    //         nameAr: "ميراى ابراهيم",
    //         nameFr: "Merai Ibrahim",
    //         dateOfBirth: "12/12/2020",
    //         grade: "third year",
    //         parentName: "Ibrahim",
    //         Tel_No: "01012123123",
    //     },
    //     {
    //         id: 4,
    //         nameAr: "رافائيل بيير ",
    //         nameFr: "Raphael Beer",
    //         dateOfBirth: "12/12/2020",
    //         grade: "fourth year",
    //         parentName: "Beer",
    //         Tel_No: ""
    //     },
    // ]

    getStudents(): Observable<IStudent[]> {
        return this._http.get<IStudent[]>("https://localhost:44340/api/students");
    }

    getStudent(id: number): Observable<IStudent> {
        return this._http.get<IStudent>("https://localhost:44340/api/students" + '/' + id);

    }

    postStudent(newStudent:IStudent):Observable<IStudent>{
        return this._http.post<IStudent>("https://localhost:44340/api/students",newStudent);
    }



}
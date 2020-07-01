import { Injectable } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { HttpClient, HttpParams } from '@angular/common/http'
import { Order } from '../models/order';
import { debug } from 'util';


@Injectable({
    providedIn: 'root'
})
export class LoginService {
    constructor(private fb: FormBuilder, private http: HttpClient) {

    }
    readonly
    BaseURI = 'http://localhost:49689/api';
    formModel = this.fb.group({
        userName: ['', Validators.required],
        password: ['', Validators.required],

    });

    Login() {
        //    debugger
        var params = new HttpParams();
        params = params.append('userName', this.formModel.value.userName);
        params = params.append('password', this.formModel.value.password);
        debugger;
        return this.http.get(this.BaseURI + '/Admin/ValidatePassword', { params: params});
    }
}

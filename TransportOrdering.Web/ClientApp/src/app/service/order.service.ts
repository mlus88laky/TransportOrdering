import { Injectable } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { HttpClient, HttpParams } from '@angular/common/http'
import { Order } from '../models/order';
import { debug } from 'util';


@Injectable({
    providedIn: 'root'
})
export class OrderService {
    constructor(private fb: FormBuilder, private http: HttpClient) {

    }

    VehicleTypeId: number;
    readonly
    BaseURI = 'http://localhost:49689/api'; 
    orderModel: Order = new Order();
    formModel = this.fb.group({
        Date: ['', Validators.required],
        StartTime: ['', Validators.required],
        VehicleCapacity: ['', Validators.required],
        StartAddress: ['', Validators.required],
        EndAddress: ['', Validators.required],
        FullName: ['', Validators.required],
        Email: ['', Validators.email],
        MobileNumber: ['', Validators.required],
        VehicleType: [''],
        capacity:['']
    });

    AddOrder() {

        this.orderModel.Date = this.formModel.value.Date;
        this.orderModel.StartTime = this.formModel.value.StartTime;
        this.orderModel.VehicleTypeId = this.VehicleTypeId;
        this.orderModel.VehicleCapacity = this.formModel.value.VehicleCapacity +" "+this.formModel.value.capacity;
        this.orderModel.StartAddress= this.formModel.value.StartAddress;
        this.orderModel.EndAddress= this.formModel.value.EndAddress;
        this.orderModel.FullName= this.formModel.value.FullName;
        this.orderModel.Email= this.formModel.value.Email;
        this.orderModel.MobileNumber= this.formModel.value.MobileNumber;       
 
        var params =new HttpParams();       
        return this.http.post(this.BaseURI + '/Order/AddOrder', this.orderModel);
    }

    GetVehicleTypeList() {
        return this.http.get(this.BaseURI + '/Order/GetVehicleTypeList');
    }
    GetOrderList() {
        return this.http.get(this.BaseURI + '/Order/GetOrderList');
    }


}

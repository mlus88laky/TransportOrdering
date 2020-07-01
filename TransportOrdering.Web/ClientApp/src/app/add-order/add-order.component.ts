
import { OrderService } from '../service/order.service';
import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { debug } from 'util';
import { Router } from '@angular/router';
import { VehicleType } from '../models/vehicleType';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-add-order',
  templateUrl: './add-order.component.html',
  styleUrls: ['./add-order.component.css']
})
export class AddOrderComponent implements OnInit {

    VehicleType: VehicleType[] = [];
    constructor(public service: OrderService, private route: Router, private toastr: ToastrService) { }

    ngOnInit(): void {
        this.service.formModel.reset();
        this.service.GetVehicleTypeList().subscribe(
            (res: any) => {
                this.VehicleType = res;
                
                debugger;
            },
            err => {
                console.log(err);
            }
        );
    }

    navigateToLogin() {
        debugger;
        this.route.navigate(["login"])
    }
    setVehicleTypeId(id:any) {
        debugger;
        this.service.VehicleTypeId = id;
    }
    onSubmit() {
        debugger;
        if (this.service.formModel.valid) {
        this.service.AddOrder().subscribe(
            (res: any) => {
                debugger;
                console.log(res); 
                if (res !=null) {
                    this.service.formModel.reset();
                    this.toastr.success('Success!', 'Referance Number' + res);
                    this.route.navigate(["main"])
                    debugger;
                } else {
                    res.errors.forEach(element => {                     
                    });
                    debugger;
                }
            },
            err => {
                debugger;
                console.log(err);
            }
        )
        }
    }

}

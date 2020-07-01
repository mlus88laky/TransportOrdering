import { Component, OnInit } from '@angular/core';
import { LoginService } from '../service/login.service';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';


@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

    constructor(public service: LoginService, private route: Router, private toastr: ToastrService) { }

    ngOnInit() {
        this.service.formModel.reset();
    }
    navigateToOrderList() {
        debugger;
        this.route.navigate(["order-list"])
    }
    onSubmit() {
        debugger;
        this.service.Login().subscribe(
            (res: any) => {
                debugger
                if (res.isValid) {
                    this.toastr.success('Admin Login', 'Login Success!');
                        this.service.formModel.reset();
                        this.navigateToOrderList();
                        debugger;                  
                } else {
                    res.errors.forEach(element => {
                      
                    });
                    debugger;
                }
            },
            err => {
                console.log(err);
            }
        )
    }

}

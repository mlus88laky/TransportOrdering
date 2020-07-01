import { Component, OnInit } from '@angular/core';
import { OrderService } from '../service/order.service';
import { Order } from '../models/order';

@Component({
  selector: 'app-order-list',
  templateUrl: './order-list.component.html',
  styleUrls: ['./order-list.component.css']
})
export class OrderListComponent implements OnInit {

    constructor(private service : OrderService) { }
    
    OrderList: Order[] = [];
    displayedColumns: string[] = ['date', 'startTime', 'vehicleTypeId', 'vehicleCapacity', 'startAddress', 'endAddress', 'fullName', 'email','mobileNumber']
    ngOnInit() {

        this.service.GetOrderList().subscribe(
            (res: any) => {
                this.OrderList = res;
                debugger;
            },
            err => {
                console.log(err);
            }
        );
  }

}

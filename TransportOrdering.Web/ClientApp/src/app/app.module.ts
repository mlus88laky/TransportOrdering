import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { AddOrderComponent } from './add-order/add-order.component';
import { OrderListComponent } from './order-list/order-list.component';
import { OrderService } from './service/order.service';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { MatButtonModule } from '@angular/material/button';
import { MatInputModule } from '@angular/material/input';
import { MatRippleModule } from '@angular/material/core';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatTooltipModule } from '@angular/material/tooltip';
import { MatSelectModule } from '@angular/material/select';
import { MatTableModule } from '@angular/material/table';
import { MatDatepickerModule } from '@angular/material/datepicker';
import { MatSliderModule } from '@angular/material/slider';
import { MatNativeDateModule } from '@angular/material/core';
import { LoginComponent } from './login/login.component';
import { LoginService } from './service/login.service';
import { ToastrModule } from 'ngx-toastr';
import { MainComponent } from './main/main.component';

@NgModule({
    declarations: [
        AppComponent,
        HomeComponent,
        AddOrderComponent,
        OrderListComponent,
        LoginComponent,
        MainComponent,

    ],
    imports: [
        BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
        HttpClientModule,
        FormsModule,
        ReactiveFormsModule,
        RouterModule.forRoot([
            { path: '', component: MainComponent, pathMatch: 'full' },
            { path: 'main', component: MainComponent, pathMatch: 'full' },
            { path: 'add-order', component: AddOrderComponent, pathMatch: 'full' },
            { path: 'login', component: LoginComponent  },
            { path: 'order-list', component: OrderListComponent  },
        ]),
        BrowserAnimationsModule,
        ToastrModule.forRoot(),
        MatButtonModule,
        MatRippleModule,
        MatFormFieldModule,
        MatInputModule,
        MatSelectModule,
        MatTooltipModule,
        MatTableModule,
        MatSliderModule,
        MatDatepickerModule,
        MatNativeDateModule,
    ],
    providers: [OrderService, LoginService],
    bootstrap: [AppComponent]
})
export class AppModule { }

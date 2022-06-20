import { Component } from '@angular/core';
import { Customer } from './customer.model';

@Component({
  templateUrl: './customer.component.html',
})
export class CustomerComponent {
  title = 'first-sample-project';
  myname = 'Amruta Musale';

  CustomerModel:Customer=new Customer();
  CustomerModels: Array<Customer> = new Array<Customer>();
  AddCustomer() {
    console.log(this.CustomerModel);
  }
  EditCustomer(input: Customer) {
    this.CustomerModel = input;
  }
  DeleteCustomer(input: Customer) {
    var index=this.CustomerModels.indexOf(input);
    this.CustomerModels.splice(index,1);
  }

}

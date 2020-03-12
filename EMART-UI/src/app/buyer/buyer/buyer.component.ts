import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

//import {BuyerComponent} from 'src/app/buyer/buyer/buyer.component';

@Component({
  selector: 'app-buyer',
  templateUrl: './buyer.component.html',
  styleUrls: ['./buyer.component.css']
})
export class BuyerComponent implements OnInit {
  constructor(private route:Router) {
    if(!(localStorage.getItem('token'))){
      this.route.navigateByUrl('/home');
    }
   }

  ngOnInit() {
    
  }

  Logout()
  {
    localStorage.clear();
    localStorage.removeItem('buyerid');
    localStorage.removeItem('token');
    localStorage.removeItem('sellerid');
    this.route.navigateByUrl('/home');
  }
}



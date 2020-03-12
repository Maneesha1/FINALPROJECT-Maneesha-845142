import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-seller',
  templateUrl: './seller.component.html',
  styleUrls: ['./seller.component.css']
})
export class SellerComponent implements OnInit {

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


import { Component, OnInit } from '@angular/core';
import { FormBuilder } from '@angular/forms';
import { Transactionhistory } from 'src/app/Models/transactionhistory';
import { BuyerService } from 'src/app/services/buyer.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-purchase-history',
  templateUrl: './purchase-history.component.html',
  styleUrls: ['./purchase-history.component.css']
})
export class PurchaseHistoryComponent implements OnInit {
  buyerid:string;
  transobj:Transactionhistory;
  translist:Transactionhistory[];
  constructor(private builder:FormBuilder,private service:BuyerService,private route:Router)
   { 
    this.buyerid= localStorage.getItem('BuyerId');
    //console.log('helloo')
    this.service.PurchaseHistory(this.buyerid).subscribe(res=>
      {
        this.transobj=res;
        console.log(this.transobj)
      },
      err=>{
        console.log(err);
      })
   }

  ngOnInit() {
  }

}
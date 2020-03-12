import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { Transactionhistory } from 'src/app/Models/transactionhistory';
import { Items } from 'src/app/Models/items';
import { BuyerService } from 'src/app/services/buyer.service';
import { Router } from '@angular/router';
import { variable } from '@angular/compiler/src/output/output_ast';

@Component({
  selector: 'app-buyproduct',
  templateUrl: './buyproduct.component.html',
  styleUrls: ['./buyproduct.component.css']
})
export class BuyproductComponent implements OnInit {
  buyerform:FormGroup;
  item:Items;
  pobj:Transactionhistory;
    constructor(private formbuilder:FormBuilder,private service:BuyerService,private route:Router) { }
  
    ngOnInit() {
  this.buyerform=this.formbuilder.group({
    transactionType:[''],
    cardNumber:[''],
    cvv:[''],
    edate:[''],
    name:[''],
    dateTime:[''],
    numberOfItems:[''],
    remarks:['']
  })
  this.item=JSON.parse(localStorage.getItem('item'));
  console.log(this.item);
  console.log(this.item.itemId);
    }
  onSubmit()
  {
    this.pobj=new Transactionhistory();
    this.pobj.id='T'+Math.round(Math.random()*999);
    this.pobj.transactionId=this.pobj.id;
    this.pobj.buyerId=localStorage.getItem('buyerId');
    this.pobj.sellerId=this.item.sellerId;
    this.pobj.numberOfItems=this.buyerform.value["numberOfItems"];
    this.pobj.itemId=this.item.itemId;
    this.pobj.transactionType=this.buyerform.value["transactionType"]
       this.pobj.dateTime=this.buyerform.value["dateTime"];
       this.pobj.remarks=this.buyerform.value["remarks"];
       console.log(this.pobj);
       this.service.BuyItem(this.pobj).subscribe(res=>{
         console.log("Purchase was Sucessfull");
         alert('Purchase Done Successfully');
       })
  
  }
    
  
  }
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from "@angular/forms";

import {Seller} from 'src/app/Models/seller'; 
import{HttpHeaders,HttpClient} from '@angular/common/http';
import { AccountService } from 'src/app/services/account.service';


@Component({
  selector: 'app-registerseller',
  templateUrl: './registerseller.component.html',
  styleUrls: ['./registerseller.component.css']
})
export class RegistersellerComponent implements OnInit {
 RegForm:FormGroup;
  submitted=false;
  list:Seller[];
  seller:Seller;

  constructor(private fromBuilder:FormBuilder,private service:AccountService) { }

  ngOnInit() {

    this.RegForm=this.fromBuilder.group({
      // SellerId:['',[Validators.required,Validators.pattern("^[0-9]{1,4}$")]],
      UserName:['',[Validators.required,Validators.pattern('^[A-Z]{3,8}$')]],
      Password:['',Validators.required],
      CompanyName:['',Validators.required],
      GSTIN:['',Validators.required],
      BriefDetails:['',Validators.required],
      PostalAddress:['',Validators.required],
      Website:['',Validators.required],
      MobileNo:['',[Validators.required,Validators.pattern("^[6-9][0-9]{9}$")]],
      EmailId:['',[Validators.required,Validators.email]],
       
    });
  }
  
  onSubmit()
  {
    this.submitted=true;
    //display from values on sucess
    if(this.RegForm.valid)
    {
      alert('sucess!!!!!!')
      console.log(JSON.stringify(this.RegForm.value));
    }
    this.Add();
  }
   get f()
  {
    return this.RegForm.controls;

  }
  onReset()
  {

    this.submitted=false;
    this.RegForm.reset();
  }
  Add()
  {
    this.seller=new Seller();
    this.seller.sellerId='S'+Math.floor(Math.random()*1000);
    this.seller.userName=this.RegForm.value["UserName"];
    this.seller.mobileNo=(this.RegForm.value["MobileNo"]);
    this.seller.companyName=this.RegForm.value["CompanyName"];
    this.seller.gstin=this.RegForm.value["GSTIN"];
    this.seller.password=this.RegForm.value["Password"];
    this.seller.postalAddress=this.RegForm.value["PostalAddress"];
    this.seller.website=this.RegForm.value["Website"];
    this.seller.emailId=this.RegForm.value["EmailId"];
    this.seller.briefDetails=this.RegForm.value["BriefDetails"];
    this.service.SellerRegister(this.seller).subscribe
    (
      res=>
      {
        console.log('Record Added');
      },
      err=>
      {
        console.log(err);
      }
    )
  }

  }


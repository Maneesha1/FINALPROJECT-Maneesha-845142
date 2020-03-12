import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from "@angular/forms";
import{HttpHeaders,HttpClient} from '@angular/common/http';

import {Buyer} from 'src/app/Models/buyer'; 
//import { Item } from '../models/item';
import { AccountService } from 'src/app/services/account.service';

@Component({
  selector: 'app-registerbuyer',
  templateUrl: './registerbuyer.component.html',
  styleUrls: ['./registerbuyer.component.css']
})
export class RegisterbuyerComponent implements OnInit {
  RegForm:FormGroup;
  submitted=false;
  list:Buyer[];
  buyer:Buyer;

  constructor(private fromBuilder:FormBuilder,private service: AccountService) { }



  
  ngOnInit() {
    this.RegForm=this.fromBuilder.group({
     
      // BuyerId:['',[Validators.required,Validators.maxLength(5)]],
      UserName:['',[Validators.required,Validators.pattern('^[a-zA-Z]{3,15}$')]],
      MobileNo:['',[Validators.required,Validators.pattern("^[6-9][0-9]{9}$")]],
      EmailId:['',[Validators.required,Validators.email]],
      Password:['',[Validators.required,Validators.minLength(6)]],

    
    });
  }


  get f()
  {
    return this.RegForm.controls;

  }
  
  onSubmit()
  {
    this.submitted=true;
    //display from values on sucess
    if(this.RegForm.valid)
    {
      // alert('sucess!!!!!!')
      this.Register();
      console.log(JSON.stringify(this.RegForm.value));
    }
    
  }
    onReset()
    {

    this.submitted=false;
    this.RegForm.reset();
    }

    Register()
    {

      this.buyer=new Buyer();
      this.buyer.buyerId='B'+Math.floor(Math.random()*1000);
      this.buyer.userName=this.RegForm.value["UserName"];
      this.buyer.mobileNo=(this.RegForm.value["MobileNo"]);
      this.buyer.password=this.RegForm.value["Password"];
      this.buyer.emailId=this.RegForm.value["EmailId"];
      this.buyer.createdDateTime=new Date();
      this.service.BuyerRegister(this.buyer).subscribe 
      (
        res=>
        {
          console.log('Record Added');
          alert("Details Registered");
        },
        err=>
        {
          console.log(err);
        }
      )
    }
  
  }

  // RegForm:FormGroup;
  // submitted=false;
  // list:Buyer[];
  // buyer:Buyer;
 




  // constructor(private fromBuilder:FormBuilder,private service:AccountService) { 
  //   this.service.BuyerRegistration(this.buyer).subscribe(res=>{
  //     this.list=res;
  //     console.log(this.list);

  // },
  // err=>{
  //   console.log(err)
  // })

// }

//   ngOnInit() {
//     this.RegForm=this.fromBuilder.group({
      // buyerId:['',[Validators.required]],
  //     userName:['',[Validators.required,Validators.pattern('^[A-Z]{3,8}$')]],
  //     password:['',Validators.required],
      
      
     
  //     mobileNo:['',[Validators.required,Validators.pattern("^[6-9][0-9]{9}$")]],
  //     emailId:['',[Validators.required,Validators.email]]
       
  //   });
  // }
  // onSubmit()
  // {
  //   this.submitted=true;
   
    
  //   //display from values on sucess
  //   if(this.RegForm.valid)
  //   {
      
  //     console.log(JSON.stringify(this.RegForm.value));
  //     this.Add();

  //   }
  //     }
  //  get f()
  // {
  //   return this.RegForm.controls;

  // }
  // onReset()
  // {

  //   this.submitted=false;
  //   this.RegForm.reset();
  // }
  // Add()
  //  {
  //    this.buyer=new Buyer();
  //   // this.item=new Item();
  //   this.buyer.buyerId='B'+Math.floor(Math.random()*1000);
  //   this.buyer.userName=this.RegForm.value["UserName"];
  //   this.buyer.password=this.RegForm.value["Password"];
  //   this.buyer.emailId=this.RegForm.value["EmailId"];
  //   this.buyer.mobileNo=this.RegForm.value["MobileNo"];
  //   this.buyer.createdDateTime=new Date();
  //   console.log(this.buyer);
  //   this.service.BuyerRegister(this.buyer).subscribe(res=>{
  //     console.log('Record Added')
  //     alert('sucess!!!!!!')
  //  },err=>
  //  {
  //    console.log(err);
  //   });
  

  //  }

  // }



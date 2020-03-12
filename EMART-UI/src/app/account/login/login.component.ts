import { Component, OnInit } from '@angular/core';
import {FormBuilder,FormGroup,Validators} from "@angular/forms";
import { Buyer } from 'src/app/Models/buyer';
import { Seller } from 'src/app/Models/seller';
import { Token } from 'src/app/Models/token';
import{Router} from '@angular/router';
import{AccountService} from 'src/app/services/account.service';
import { Local } from 'protractor/built/driverProviders';


@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  loginForm:FormGroup;
  submitted:boolean;
  buyer:Buyer;
  seller:Seller;
  token:Token;
  role:string;
  // id:String;
  // pwd:string;
  username:string;
  password:string;
  
  constructor(private formbuilder:FormBuilder,private service:AccountService,private route:Router) { }

  ngOnInit() {
    this.loginForm=this.formbuilder.group({
      username:['',Validators.required],
      password:['',Validators.required],
      role:['']
    });
  }
  public Login(){
    console.log("heloo");
    this.submitted=true;
     if(this.loginForm.valid)
    {
     this.token=new Token();
     this.buyer=new Buyer();
     this.seller=new Seller();
     let uname=this.loginForm.value["username"];
     let pass=this.loginForm.value["password"];
     let role=this.loginForm.value["role"];
    // console.log(this.role);
     if(role=='buyer')
     {
        let token=new Token();
        this.service.BuyerLogin(uname,pass).subscribe(res=>{
        token=res;
        console.log(token);

localStorage.setItem('token',this.token.token);
        localStorage.setItem('BuyerId',token.buyerId);
        console.log(token.buyerId);
      if(token.message=='success')
      {
        //localStorage.setItem('buyerid',token.BuyerId);
        this.route.navigateByUrl("/buyer");
      }
      else 
      {
        alert('invalid buyer');
     }
    
    });
       }
    //seller login
    if(role=='seller')
    {
      let token=new Token();
      this.service.SellerLogin(uname,pass).subscribe(res=>{
      token=res;
      console.log(token);

      localStorage.setItem('token',this.token.token);
      localStorage.setItem('SellerId',token.sellerId);
      console.log(token.sellerId);
      if(token.message=='success')
      {
       // localStorage.setItem('sellerId',token.SellerId);
        this.route.navigateByUrl("/seller");
      }
      else{
        alert('invalid seller')
      }
     
    });
  }
  if(uname=="Admin" &&pass=="12345"){
     
localStorage.setItem('token',this.token.token);
    this.route.navigateByUrl("/admin");
   }
     }
    // alert(this.role);
    // switch(this.role){
    //   case "buyer":
    //     this.route.navigateByUrl("home");
    //     break;
    //     case "seller":
    //     this.route.navigateByUrl("shome");
    //     break;
    //     case "admin":
    //     this.route.navigateByUrl("admin-home");
    //     break;
    //     default:
    //       alert("invalid credentials");
    // }
   
    //
      }
 
   

  onSubmit()
  {
    this.submitted=true;
    //display from values on sucess
    if(this.loginForm.valid)
    {
      alert('sucess!!!!!!')
      console.log(JSON.stringify(this.loginForm.value));
    }
    this.Login();
  }
   get f()
  {
    return this.loginForm.controls;

  }
  onReset()
  {

    this.submitted=false;
    this.loginForm.reset();
  }

  }

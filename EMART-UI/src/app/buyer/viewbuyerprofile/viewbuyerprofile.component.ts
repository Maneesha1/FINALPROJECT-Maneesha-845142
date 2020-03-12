import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder } from '@angular/forms';
import { Buyer } from 'src/app/Models/buyer';
import { BuyerService } from 'src/app/services/buyer.service';

@Component({
  selector: 'app-viewbuyerprofile',
  templateUrl: './viewbuyerprofile.component.html',
  styleUrls: ['./viewbuyerprofile.component.css']
})
export class ViewbuyerprofileComponent implements OnInit {
  itemForm:FormGroup;
  submitted=false;
buyer:Buyer;
 buyerlist:Buyer[];
 
  constructor(private fromBuilder:FormBuilder,private service:BuyerService) {
    let sid= localStorage.getItem('BuyerId')
    console.log(sid);
 this.service.ViewProfile(sid).subscribe(res=>
  {
    this.buyer=res;
    console.log("get");
    console.log(this.buyer);
    console.log('Id Found');
    //console.log(res);
    this.itemForm.patchValue(
      {
       
      buyerId:localStorage.getItem('BuyerId'),
      userName:this.buyer.userName,
        password:this.buyer.password,
      emailId:this.buyer.emailId,
       mobileNo:this.buyer.mobileNo,
       
        
      }
    )
  },
  err=>
  {
    console.log(err);
  }
)

   

   }

  ngOnInit() {
   
    this.itemForm=this.fromBuilder.group({
       buyerId:[''],
        userName:[''],
      password:[''],
    
      emailId:[''],
      mobileNo:[''],
  
    });
  }
  onSubmit()
  {
    this.submitted=true;
   
}
get f()
{
  return this.itemForm.controls;
}
onReset()
{
this.submitted=false;
this.itemForm.reset();
}
EditProfile()
{
  this.buyer=new Buyer();
  console.log(this.buyer);
  this.buyer.buyerId=localStorage.getItem('BuyerId');
  this.buyer.userName=this.itemForm.value["userName"];
  this.buyer.password=this.itemForm.value["password"];
  this.buyer.emailId=this.itemForm.value["emailId"];
  this.buyer.mobileNo=this.itemForm.value["mobileNo"];

this.buyer.createdDateTime=new Date();
  
// this.item.createdDateTime=this.itemForm.value["createdDateTime"];

  console.log(this.buyer);
  this.service.EditProfile(this.buyer).subscribe(res=>
    {
      console.log('Record Updated');
      alert('updated succefully');
    })
}
}
import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder } from '@angular/forms';
import { Seller } from 'src/app/Models/seller';
import { SellerService } from 'src/app/services/seller.service';

@Component({
  selector: 'app-viewsellerprofile',
  templateUrl: './viewsellerprofile.component.html',
  styleUrls: ['./viewsellerprofile.component.css']
})
export class ViewsellerprofileComponent implements OnInit {
  itemForm:FormGroup;
  submitted=false;
seller:Seller;
 sellerlist:Seller[];
  constructor(private fromBuilder:FormBuilder,private service: SellerService) {
    let sid= localStorage.getItem('SellerId')
    console.log(sid);
 this.service.ViewProfile(sid).subscribe(res=>
  {
    this.seller=res;
    console.log("get");
    console.log(this.seller);
    console.log('Id Found');
    //console.log(res);
    this.itemForm.patchValue(
      {
      sellerId:localStorage.getItem('SellerId'),
      userName:this.seller.userName,
        password:this.seller.password,
      companyName:this.seller.companyName,
        gstin:this.seller.gstin,
        briefDetails:this.seller.briefDetails,
        postalAddress:this.seller.postalAddress,
        website:this.seller.website,
        emailId:this.seller.emailId,
        mobileNo:this.seller.mobileNo       
      }
    )
  },
  err=>
  {
    console.log(err);
  })
}

  ngOnInit() {
   
    this.itemForm=this.fromBuilder.group({
        sellerId:[''],
        userName:[''],
      password:[''],
      briefDetails:[''],
      companyName:[''],
      gstin:[''],
      postalAddress:[''],
      emailId:[''],
      mobileNo:[''],
      website:['']

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
  this.seller=new Seller();
  console.log(this.seller);
  this.seller.sellerId=localStorage.getItem('SellerId');
  this.seller.userName=this.itemForm.value["userName"];
  this.seller.password=this.itemForm.value["password"];
  this.seller.emailId=this.itemForm.value["emailId"];
  this.seller.mobileNo=this.itemForm.value["mobileNo"];
  this.seller.companyName=this.itemForm.value["companyName"];
  this.seller.gstin=this.itemForm.value["gstin"];
  this.seller.briefDetails=this.itemForm.value["briefDetails"];
  this.seller.postalAddress=this.itemForm.value["postalAddress"];
  this.seller.website=this.itemForm.value["website"];
// this.item.createdDateTime=this.itemForm.value["createdDateTime"];

  console.log(this.seller);
  this.service.EditProfile(this.seller).subscribe(res=>
    {
      console.log('Record Updated');
    })
}

}


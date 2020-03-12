import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from "@angular/forms";
import{Items} from 'src/app/Models/items';
import{HttpHeaders,HttpClient} from '@angular/common/http';
import { SellerService } from 'src/app/services/seller.service';
import { Category } from 'src/app/Models/category';
import { Subcategory } from 'src/app/Models/subcategory';
import { Router } from '@angular/router';



@Component({
  selector: 'app-additems',
  templateUrl: './additems.component.html',
  styleUrls: ['./additems.component.css']
})
export class AdditemsComponent implements OnInit {
  itemForm:FormGroup;
  submitted=false;
 item:Items;
 itemlist:Items[];
  categorylist:Category[];
subcategorylist:Subcategory[];
catid:string;
image:string;
selectedFile : File = null;
  constructor(private fromBuilder:FormBuilder,private service: SellerService,private route:Router)
   {
     this.service.GetCategories().subscribe(res=>{
     this.categorylist=res;
     console.log(this.categorylist);

    //  this.service.GetSubCategories(this.catid).subscribe(res=>{
    //   this.subcategorylist=res;
    //   console.log(this.categorylist);
     
    // })
   }   

   )
  
  }

  ngOnInit() {



    this.itemForm=this.fromBuilder.group({
     
    SellerId:['',[Validators.required]],
      //SellerName:['',[Validators.required,Validators.pattern('^[a-zA-Z]{3,15}$')]],
      ItemName:['',[Validators.required,Validators.pattern('^[a-zA-Z]{3,15}$')]],
      // CategoryId:['',[Validators.required,Validators.pattern("^[0-9]{1,5}$")]],
     Price:['',[Validators.required]],
      Description:['',Validators.required],
      CategoryId:[''],
      CategoryName:[''],
      StockNumber:['',Validators.required],
      Remarks:[''],
      SubcategoryId:[''],
     SubcategoryName:['']
    

  });

}





get f()
  {
    return this.itemForm.controls;

  }
  
  onSubmit()
  {
    this.submitted=true;
    //display from values on sucess
    if(this.itemForm.valid)
    {
      alert('success!!!!!!')
      console.log(JSON.stringify(this.itemForm.value));
    }
    this.Add();
  }
    onReset()
    {

    this.submitted=false;
    this.itemForm.reset();
    }


  //   GetCategories()
  //  {
  //    this.service.GetCategories().subscribe(res=>
  //     {
  //       this.categorylist=res;
  //       console.log(this.categorylist);
  //     },
  //     err=>
  //     {
  //       console.log(err);
  //     })
  //   }




    GetSub()
   {
     let id=this.itemForm.value["CategoryName"];
     console.log(id);
     
     this.service.GetSubCategories(id).subscribe(res=>
      {
        this.subcategorylist=res;
        console.log(this.subcategorylist);
      },
      err=>
      {
        console.log(err);
      })
    }
    Add()
    {

      this.item=new Items();
      this.item.itemId='I'+Math.floor(Math.random()*1000);
      this.item.sellerId=this.itemForm.value["SellerId"];
      this.item.itemName=this.itemForm.value["ItemName"];
      this.item.image=this.image;
      this.item.categoryId=(this.itemForm.value["CategoryName"]);
      this.item.subcategoryId=(this.itemForm.value["SubcategoryName"]);
      this.item.remarks=this.itemForm.value["Remarks"];
         
        this.item.stockNumber=this.itemForm.value["StockNumber"];
      this.item.description=this.itemForm.value["Description"];
      this.item.price=this.itemForm.value["Price"];
      console.log(this.item);
      this.service.AddItem(this.item).subscribe 
      (
        res=>
        {
          console.log(this.item)
          console.log('Record Added');
        },
        err=>
        {
          console.log(err);
        }
      )
    }



    fileEvent(event){
      this.image = event.target.files[0].name;

  
  }
}

  

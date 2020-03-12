import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from "@angular/forms";
import {Category} from 'src/app/Models/category'; 
import{HttpHeaders,HttpClient} from '@angular/common/http';
import { AdminService } from 'src/app/services/admin.service';
import { Router } from '@angular/router';

//import {Admin} from 'src/app/Models/category'; 


@Component({
  selector: 'app-addcategory',
  templateUrl: './addcategory.component.html',
  styleUrls: ['./addcategory.component.css']
})
export class AddcategoryComponent implements OnInit {
  addcatForm:FormGroup;
  submitted=false;
  category:Category;
  categorylist:Category[];
  constructor(private route:Router,private fromBuilder:FormBuilder,private service: AdminService) { }



  
  ngOnInit() {
    this.addcatForm=this.fromBuilder.group({
     
      
      CategoryName:['',[Validators.required,Validators.pattern('^[a-zA-Z]{3,15}$')]],
      BriefDetails:['',[Validators.minLength(5)]],

    
    });
  }


  get f()
  {
    return this.addcatForm.controls;

  }
  
  onSubmit()
  {
    this.submitted=true;
    //display from values on sucess
    if(this.addcatForm.valid)
    {
      alert('success!!!')
      console.log(JSON.stringify(this.addcatForm.value));
    }
    this.Add();
  }
    onReset()
    {

    this.submitted=false;
    this.addcatForm.reset();
    }

    Add()
    {

      this.category=new Category();
      this.category.categoryId='C'+Math.floor(Math.random()*10000);
      this.category.categoryName=this.addcatForm.value["CategoryName"];
      this.category.briefDetails=this.addcatForm.value["BriefDetails"];
      this.service.AddCategories(this.category).subscribe 
      (
        res=>
        {
          console.log('Record Added');
           this.route.navigateByUrl('/admin/viewcategories');
        },
        err=>
        {
          console.log(err);
        }
      )
    }
  
  }

  
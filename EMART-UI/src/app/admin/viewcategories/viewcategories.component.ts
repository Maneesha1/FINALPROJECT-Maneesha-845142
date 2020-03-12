import { Component, OnInit } from '@angular/core';
import { Category } from 'src/app/Models/category';
import { FormGroup, FormBuilder } from '@angular/forms';
import { AdminService } from 'src/app/services/admin.service';

@Component({
  selector: 'app-viewcategories',
  templateUrl: './viewcategories.component.html',
  styleUrls: ['./viewcategories.component.css']
})
export class ViewcategoriesComponent implements OnInit {
  viewcatForm:FormGroup;
  viewcatList:Category[];
  category: Category;
  
  constructor(private formbuilder:FormBuilder,private service:AdminService) { 
   
  }

  View()
  {
    this.service.ViewCategories().subscribe(res=>
      {
        this.viewcatList=res;
        console.log(this.viewcatList)
      
      },
      err=>{
        console.log(err);
      })
        
  }
  

  ngOnInit() {
  
    this.viewcatForm=this.formbuilder.group({
      
       CategoryId:[''],
       CategoryName:[''],
       BriefDetails:[''],
       
           // CategoryName:[''],
 // CategoryId:['',[Validators.required,Validators.pattern("^[0-9]{1,5}$")]],
   });
   this.View();
 }

 GetCatById(catid:string)
 {

   this.service.GetCatById(catid).subscribe 
      (
        res=>
        {
          this.category=res;
        console.log("get");
          console.log(this.category);
          console.log('Id Found');
          this.viewcatForm.setValue(
            {
              CategoryId:this.category.categoryId,
              CategoryName:this.category.categoryName,
              BriefDetails:this.category.briefDetails  
            }
          )
        },
        err=>
        {
          console.log(err);
        }
      )
      // this.Edit(this.category);
    }
 

 Edit()
  {
    let catobj=new Category();  
    console.log(catobj);
    catobj.categoryId=this.viewcatForm.value['CategoryId'];
    catobj.categoryName=this.viewcatForm.value['CategoryName'];
    // catobj.CategoryId=this.viewcatForm.value['CategoryId'];
    catobj.briefDetails=this.viewcatForm.value['BriefDetails'];
    this.service.EditCategories(catobj).subscribe(res=>{
        this.category=res;
        console.log(this.category);
      
  })
  
    }
   

    Delete(catid:string)
    {
      this.service.DeleteCategories(catid).subscribe
  (
    res=>
    {
      console.log('Record Deleted');
    },
    err=>
    {
      console.log(err);
    }
  )
  this.View();
}
    }
    
  
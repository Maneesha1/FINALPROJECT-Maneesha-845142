import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder } from '@angular/forms';

@Component({
  selector: 'app-contact',
  templateUrl: './contact.component.html',
  styleUrls: ['./contact.component.css']
})
export class ContactComponent implements OnInit {
  ContactForm:FormGroup;
  submitted=false;
  
  constructor(private fromBuilder:FormBuilder) { }

  ngOnInit() {
    this.ContactForm=this.fromBuilder.group({
      name:[''],
      email:[''],
      phoneno:[''],
      queries:[''],
    });
  }
  get f()
  {
    return this.ContactForm.controls;

  }
  
  onSubmit()
  {
    
      alert('sucess!!!!!!')
   
  }

}

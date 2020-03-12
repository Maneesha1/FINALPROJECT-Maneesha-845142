import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AddsubcategoryComponent } from './addsubcategory.component';

describe('AddsubcategoryComponent', () => {
  let component: AddsubcategoryComponent;
  let fixture: ComponentFixture<AddsubcategoryComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AddsubcategoryComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AddsubcategoryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ViewbuyerprofileComponent } from './viewbuyerprofile.component';

describe('ViewbuyerprofileComponent', () => {
  let component: ViewbuyerprofileComponent;
  let fixture: ComponentFixture<ViewbuyerprofileComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ViewbuyerprofileComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ViewbuyerprofileComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

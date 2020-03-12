import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ViewsellerprofileComponent } from './viewsellerprofile.component';

describe('ViewsellerprofileComponent', () => {
  let component: ViewsellerprofileComponent;
  let fixture: ComponentFixture<ViewsellerprofileComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ViewsellerprofileComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ViewsellerprofileComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

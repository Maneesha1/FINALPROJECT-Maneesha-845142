import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { RegisterbuyerComponent } from './registerbuyer.component';

describe('RegisterbuyerComponent', () => {
  let component: RegisterbuyerComponent;
  let fixture: ComponentFixture<RegisterbuyerComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ RegisterbuyerComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RegisterbuyerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

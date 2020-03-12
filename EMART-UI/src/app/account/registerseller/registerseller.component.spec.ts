import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { RegistersellerComponent } from './registerseller.component';

describe('RegistersellerComponent', () => {
  let component: RegistersellerComponent;
  let fixture: ComponentFixture<RegistersellerComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ RegistersellerComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RegistersellerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

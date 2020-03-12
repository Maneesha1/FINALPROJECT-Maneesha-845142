import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ViewitemsComponent } from './viewitems.component';

describe('ViewitemsComponent', () => {
  let component: ViewitemsComponent;
  let fixture: ComponentFixture<ViewitemsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ViewitemsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ViewitemsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

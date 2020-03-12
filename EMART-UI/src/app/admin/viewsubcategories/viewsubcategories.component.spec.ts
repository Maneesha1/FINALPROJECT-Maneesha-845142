import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ViewsubcategoriesComponent } from './viewsubcategories.component';

describe('ViewsubcategoriesComponent', () => {
  let component: ViewsubcategoriesComponent;
  let fixture: ComponentFixture<ViewsubcategoriesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ViewsubcategoriesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ViewsubcategoriesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

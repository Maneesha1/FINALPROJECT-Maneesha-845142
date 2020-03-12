import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { BblockUnblockComponent } from './bblock-unblock.component';

describe('BblockUnblockComponent', () => {
  let component: BblockUnblockComponent;
  let fixture: ComponentFixture<BblockUnblockComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ BblockUnblockComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BblockUnblockComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

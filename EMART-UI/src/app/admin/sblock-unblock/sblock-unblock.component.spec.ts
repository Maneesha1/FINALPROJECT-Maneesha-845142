import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SblockUnblockComponent } from './sblock-unblock.component';

describe('SblockUnblockComponent', () => {
  let component: SblockUnblockComponent;
  let fixture: ComponentFixture<SblockUnblockComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SblockUnblockComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SblockUnblockComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

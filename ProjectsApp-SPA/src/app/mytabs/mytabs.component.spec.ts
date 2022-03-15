/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { MytabsComponent } from './mytabs.component';

describe('MytabsComponent', () => {
  let component: MytabsComponent;
  let fixture: ComponentFixture<MytabsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MytabsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MytabsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

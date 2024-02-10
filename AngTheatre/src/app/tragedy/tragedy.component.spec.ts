import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TragedyComponent } from './tragedy.component';

describe('TragedyComponent', () => {
  let component: TragedyComponent;
  let fixture: ComponentFixture<TragedyComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [TragedyComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(TragedyComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

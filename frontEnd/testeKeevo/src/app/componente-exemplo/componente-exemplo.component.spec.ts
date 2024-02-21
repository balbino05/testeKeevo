import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ComponenteExemploComponent } from './componente-exemplo.component';

describe('ComponenteExemploComponent', () => {
  let component: ComponenteExemploComponent;
  let fixture: ComponentFixture<ComponenteExemploComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ComponenteExemploComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ComponenteExemploComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

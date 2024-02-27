import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-tarefas',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './tarefas.component.html',
  styleUrl: './tarefas.component.css'
})
export class TarefasComponent  implements OnInit{
  public tarefasData: any = [{
    title: 'Tarefa 1',
    description: 'Descrição 1',
    status: 'pending',
    created_at: '2021-08-30T14:18:00.000Z',
  },
  {
    title: 'Tarefa 2',
    description: 'Descrição 2',
    status: 'pending',
    created_at: '2021-08-30T14:18:00.000Z',
  },];

  constructor() {}

  ngOnInit(): void {

  }

}

import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { response } from 'express';
import { error } from 'console';

@Component({
  selector: 'app-tarefas',
  standalone: true,
  imports: [CommonModule, HttpClientModule],
  templateUrl: './tarefas.component.html',
  styleUrl: './tarefas.component.css'
})
export class TarefasComponent  implements OnInit{
  public tarefasData: any = [];

  constructor(private http : HttpClient) { }

  ngOnInit(): void {
    this.getTarefas();
  }

  public getTarefas(): void {
    this.http.get('https://localhost/api/task').subscribe(
      (response : any) => { // Change the type of 'data' to 'Object'
        this.tarefasData = response;
      },
      (error) => {
        console.error('Erro na requisição:', error);
        // Lidar com erros
      }
    );
    // Implemente a lógica para buscar as tarefas
    this.tarefasData = [
      {
        id: 1,
        title: 'Tarefa 1',
        description: 'Descrição 1',
        status: 'pending',
        created_at: '2021-08-30T14:18:00.000Z',
      },
      {
        id: 2,
        title: 'Tarefa 2',
        description: 'Descrição 2',
        status: 'pending',
        created_at: '2021-08-30T14:18:00.000Z',
      },
      {
        id: 3,
        title: 'Tarefa 3',
        description: 'Descrição 3',
        status: 'pending',
        created_at: '2021-08-30T14:18:00.000Z',
      },

    ];
  }

}

import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-tabela-dados',
  templateUrl: './tabela-dados.component.html',
  styleUrls: ['./tabela-dados.component.css'],
})
export class TabelaDadosComponent implements OnInit {
  dados: any = []; // Certifique-se de ajustar o tipo conforme a estrutura dos seus dados

  constructor(private http: HttpClient) {}

  ngOnInit(): void {
    this.http.get('https://localhost/dados').subscribe(
      (data : any) => { // Change the type of 'data' to 'Object'
        this.dados = data;
      },
      (error) => {
        console.error('Erro na requisição:', error);
        // Lidar com erros
      }
    );
  }
}

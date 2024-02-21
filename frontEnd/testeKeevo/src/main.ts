import { bootstrapApplication } from '@angular/platform-browser';
import { appConfig } from './app/app.config';
import { AppComponent } from './app/app.component';
import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { TabelaDadosComponent } from './app/tabela-dados/tabela-dados.component';

bootstrapApplication(AppComponent, appConfig)
  .catch((err) => console.error(err));

  @NgModule({
    declarations: [
      // ... seus componentes
      TabelaDadosComponent,
    ],
    imports: [
      HttpClientModule, // Adicione esta linha
      // ... outros módulos
    ],
  })
  export class AppModule { }

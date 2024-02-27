import { bootstrapApplication } from '@angular/platform-browser';
import { appConfig } from './app/app.config';
import { AppComponent } from './app/app.component';
import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { TabelaDadosComponent } from './app/tabela-dados/tabela-dados.component';
import { LoginComponent } from './app/login/login.component';
import { TarefasComponent} from './app/tarefas/tarefas.component';

bootstrapApplication(AppComponent, appConfig)
  .catch((err) => console.error(err));

@NgModule({
  declarations: [
    TabelaDadosComponent, // Add TabelaDadosComponent to the declarations array
    // ... seus componentes
  ],
  imports: [
    HttpClientModule, // Adicione esta linha
    LoginComponent, // Move LoginComponent to the imports array
    TarefasComponent, // Move TarefasComponent to the imports array
    // ... outros módulos
  ],
})
export class AppModule { }

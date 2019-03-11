import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppComponent } from './app.component';
import { RouterModule } from '@angular/router';
import { ListaProdutoComponent } from './loja/listaProduto.component';

@NgModule({
  declarations: [
      AppComponent,
      ListaProdutoComponent
  ],
  imports: [
      BrowserModule,
      RouterModule.forRoot([], { useHash: true, enableTracing: true })
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

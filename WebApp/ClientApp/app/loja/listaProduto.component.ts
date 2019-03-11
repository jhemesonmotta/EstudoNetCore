import { Component } from '@angular/core';

@Component({
    selector: 'lista-produto',
    templateUrl: "./listaProduto.component.html",
    styleUrls: []
})

export class ListaProdutoComponent {
    public produtos = [
        {
            titulo      : "Produto 1",
            preco       : 10

        },
        {
            titulo      : "Produto 2",
            preco       : 100.50

        },
        {
            titulo      : "Produto 3",
            preco       : 1000.21

        }
    ];
}

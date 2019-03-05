"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var Produto = /** @class */ (function () {
    function Produto(sigla) {
        this.sigla = sigla;
        this.id = 0;
    }
    Produto.prototype.exibirSigla = function () {
        alert(this.sigla);
    };
    Produto.prototype.obterNome = function () {
        return this.nome;
    };
    Produto.prototype.obterId = function () {
        return this.id;
    };
    Object.defineProperty(Produto.prototype, "setDescricao", {
        set: function (val) {
            this.descricao = val;
        },
        enumerable: true,
        configurable: true
    });
    Object.defineProperty(Produto.prototype, "getDescricao", {
        get: function () {
            return this.descricao;
        },
        enumerable: true,
        configurable: true
    });
    return Produto;
}());
exports.Produto = Produto;
//# sourceMappingURL=produto.js.map
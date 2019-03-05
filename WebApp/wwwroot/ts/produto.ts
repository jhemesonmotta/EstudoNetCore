export class Produto{
    public id: number = 0;
    public nome: string;
    public descricao: string;
    public preco: number;

    constructor(private sigla: string) {

    }

    public exibirSigla() {
        alert(this.sigla);
    }

    public obterNome(): string {
        return this.nome;
    }

    public obterId(): number {
        return this.id;
    }

    set setDescricao(val) {
        this.descricao = val;
    }

    get getDescricao() {
        return this.descricao;
    }
}
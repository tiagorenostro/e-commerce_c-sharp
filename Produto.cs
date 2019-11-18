namespace e_commerce{
    class Produto{
        public float Valor;
        public long Codigo;
        public int QuantidadeEmEstoque;
    }

    class Eletro: Produto{
        public string Marca;
        public int Voltagem;

    }

    class Geladeira: Eletro{
        public string Cor;
        public string GetDescricao(){
            return "Geladeira" +Marca +" " +Cor;
        }
    }

    class Televisao: Eletro{
        public int Polegada;

        public string GetDescricao(){
            return "Televisao " +Marca +" " +Polegada;
        }
    }

    class Livro: Produto{
        public string Titulo;
        public string Autor;

        public string GetDescricao(){
            return "Livro " +Titulo;
        }
    }
}

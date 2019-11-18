using System.Collections.Generic;

namespace e_commerce{
    class ItemDoPedido{
        Produto[] Produto = new Produto[0];
        int Quantidade;

        public double ObterValorDoItem(){
            foreach (Produto p in Produto){
                return p.Valor * Quantidade;
            }
            return 0;
        }
    }

    class Pedido: ItemDoPedido{
        List<ItemDoPedido> itens = new List<ItemDoPedido>();
        double ValorDoFrete;

        double ObterValorTotal(){
            double soma_valor_total = 0;
            foreach (var item in itens){
                soma_valor_total += item.ObterValorDoItem();
            }
            return soma_valor_total + ValorDoFrete;
        }

        string ObterResumo(){
            string resumo = "";
            return resumo;
        }
    }
}
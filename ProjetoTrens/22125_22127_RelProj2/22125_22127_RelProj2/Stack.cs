using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

interface Stack<Dado>
{
    int tamanho();
    bool estaVazia();
    void empilhar(Dado elemento);

    Dado desempilhar();

    Dado oTopo();

}

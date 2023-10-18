using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula18102023
{
    // a classe que irá representar um cliente
    internal class Cliente
    {
        // as variaveis representam atributos para o nosso cliente
        private string _nome;
        private string _sobrenome;
        private string _cpf;

        // o método construtor obriga a passagem de parâmetros obrigatórios
        public Cliente(string nome, string sobrenome, string cpf)
        {
            _nome = nome;
            _sobrenome = sobrenome;
            _cpf = cpf;
        }

        //método sobreescrito, principio de encapsulamento
        public override string ToString()
        {
            return $"Nome: {_nome} | Sobrenome: {_sobrenome} | CPF: {_cpf}";
        }
    }
}
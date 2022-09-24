using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace ClickToStudy.Models
{
    public class Pessoa
    {
        public string Nome { get; set; } = "";


        public int Idade { get; set; }
        public string CPF { get; set; } = "";
        public string DtNascimento { get; set; } = "01/01/1900";
        public char Sexo { get; set; }
        public string Celular { get; set; } = "";




        //public int getIdade()
        //{
        //    return Idade;
        //}

        //public void setIdade(int idade)
        //{
        //    Idade = idade;
        //}


        //public string getCPF()
        //{
        //    return CPF;
        //}

        //public void setCPF(string cpf)
        //{
        //    CPF = cpf;
        //}


        //public DateOnly getDtNascimento()
        //{
        //    return DtNascimento;
        //}

        //public void setDtNascimento(DateOnly dtnascimento)
        //{
        //    DtNascimento = dtnascimento;
        //}

        //public char getSexo()
        //{
        //    return Sexo;
        //}

        //public void setSexo(char sexo)
        //{
        //    Sexo = sexo;
        //}

        //public string getCelular()
        //{
        //    return Celular;
        //}

        //public void setCelular(string celular)
        //{
        //    Celular = celular;
        //}

    }
}

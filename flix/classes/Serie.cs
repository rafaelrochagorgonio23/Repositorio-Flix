using System.Collections.Generic;
using System;

namespace flix
{
    public class Serie : EntidadeBase
    {
        //Atributos

        public Serie(genero genero, string titulo, string descricao, int ano, bool excluido)
        {
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = excluido;

        }
        private genero Genero { get; set; }//Genero é um enum

        private string Titulo { get; set; }

        private string Descricao { get; set; }

        private int Ano { get; set; }


        private bool Excluido { get; set; }



        //Métodos

        public Serie(int Id, genero genero, string Titulo, string Descricao, int Ano)
        {
            this.Id = Id;
            this.Genero = Genero;
            this.Titulo = Titulo;
            this.Descricao = Descricao;
            this.Ano = Ano;
            this.Excluido = false;
        }

        public override string ToString()
        {
            //Enviroment.NewLine - para salta de linha

            string retorno = "";
            
            //object Enviroment = null;

            retorno += "Gênero " + this.Genero +  Environment.NewLine;

            retorno += "Titulo " + this.Titulo +  Environment.NewLine;

            retorno += "Descrição " + this.Descricao +  Environment.NewLine;

            retorno += "Ano de Inicio " + this.Ano +  Environment.NewLine;

            retorno += "Excluido" + this.Excluido;


            return retorno;

        }

        //Métodos encapsulamento
        public string retornoTitulo()
        {
            return this.Titulo;
        }

        public int retornaId()
        {
            return this.Id;
        }

        public int retornaExcluido()
        {
            return this.Excluido;
        }

        public void Excluir()
        {
            this.Excluido = true;
        }
    }
}
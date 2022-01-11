using System;

namespace DIO.Dramas
{
    public class Serie: EntidadeBase
    {
        //Atributos

        private Genero Genero {get; set;}
        private string Titulo {get; set;}

        private string Descricao {get; set;}

        private int Ano {get; set;}

        private int NumeroDeEpisodios {get;set;}

        private string PaisDeOrigem {get;set;}

        private bool Excluido {get; set;}


        

        //Métodos

        public Serie(int id, Genero genero, string titulo, string descricao, int ano, int numeroEpisodios, string paisOrigem)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.NumeroDeEpisodios = numeroEpisodios;
            this.PaisDeOrigem = paisOrigem;
            this.Excluido =  false;
        }
        
        public override string ToString()
        {
            // Utilizando o Environment NewLine
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Título: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Início: " + this.Ano + Environment.NewLine;
            retorno += "Número de Episódios: " + this.NumeroDeEpisodios + Environment.NewLine;
            retorno += "País de Origem: " + this.PaisDeOrigem + Environment.NewLine;
            retorno += "Excluído: " + this.Excluido;
            return retorno;

        }

        public string RetornaTitulo()
        {
            return this.Titulo;
        }

        public int RetornaId()
        {
            return this.Id;
        }

        public bool RetornaExcluido()
        {
            return this.Excluido;
        }

        public void Excluir(){
            this.Excluido = true;
        }
    }
}
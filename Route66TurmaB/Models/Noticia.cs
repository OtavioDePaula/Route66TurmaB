using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace Route66TurmaB.Models
{
    public class Noticia
    {
        public int NoticiaId { get; set; }
        public string Titulo { get; set; }
        public string Categoria { get; set; }
        public string Conteudo { get; set; }
        public DateTime Data { get; set; }



        //retorna uma lista e numerada
        public IEnumerable<Noticia> TodasAsNoticias()
        {
            var listaNoticias = new Collection<Noticia>
            {
                new Noticia
                {
                    NoticiaId = 1,
                    Categoria = "Esportes",
                    Titulo = "O time é vencedor",
                    Conteudo = "O time do Brasil venceu de 5x2 o campeonato sub 20 mundial.",
                    Data = new DateTime(22/03/2020)
                },

                new Noticia
                {
                    NoticiaId = 2,
                    Categoria = "Moda",
                    Titulo = "Desfile da Gucci",
                    Conteudo = "Em São Paulo Aconteceu o maior desfile da Gucci já visto na América Latina.",
                    Data = new DateTime(18/11/2020)
                },

                new Noticia
                {
                    NoticiaId = 3,
                    Categoria = "Culinária",
                    Titulo = "Bolo de cenoura",
                    Conteudo = "Hoje a Paumirinha nos ensina como fazer um maravilho bolo de cenoura.",
                    Data = new DateTime(15/04/2020)
                },

                new Noticia
                {
                    NoticiaId = 4,
                    Categoria = "Política",
                    Titulo = "Deabates Começam",
                    Conteudo = "Nessa Terça vai rolar o primeiro debate das eleições.",
                    Data = new DateTime(02/08/2020)
                },

                new Noticia
                {
                    NoticiaId = 5,
                    Categoria = "Culinária",
                    Titulo = "Bolo de maçã",
                    Conteudo = "Ana Maria com inveja de Paumirinha, Mpstra como fazer um bolo de maçã.",
                    Data = new DateTime(15/04/2020)
                }
            };
            return listaNoticias;
        }
    }
}
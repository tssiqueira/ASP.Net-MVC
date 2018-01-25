using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;


namespace RotasMVC.Models
{
    public class Noticia
    {
        public int NoticiaId { get; set; }
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public string Categoria { get; set; }
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}")]
        public DateTime Data { get; set; }

        public IEnumerable<Noticia> TodasAsNoticias()
        {
            var retorno = new Collection<Noticia>
            {
                new Noticia
                {
                    NoticiaId = 1,
                    Categoria = "Esportes",
                    Titulo = "Felipe Massa ganha F1",
                    Conteudo = "Numa tarde de chuva Felipe Massa ganha F1 no Brasil...",
                    Data = new DateTime(2012,7,5)
                },
                new Noticia
                {
                    NoticiaId = 2,
                    Categoria = "Politica",
                    Titulo = "Presidente assina convenios",
                    Conteudo = "Durante reuniao presidente Ismael assinou os convenios...",
                    Data = new DateTime(2012,7,3)
                },
                new Noticia
                {
                    NoticiaId = 3,
                    Categoria = "Politica",
                    Titulo = "Vereador eh eleito pela 4 vez",
                    Conteudo = "Vereador Fabio Pratt eh eleito pela quarta vez...",
                    Data = new DateTime(2012,7,20)
                }

            };
            return retorno; 
        }



    }
}
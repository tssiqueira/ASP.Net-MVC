/*esse modulo representa as tabelas do banco de dados (aqui posso criar aluno, professor etc)*/

using System;
using System.ComponentModel;

namespace TiSelvagem.Dominio
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        [DisplayName("Mamae")]
        public string Mae { get; set; }
        [DisplayName("Data de Nascimento")]
        public DateTime DataNascimento { get; set; }
    }
}

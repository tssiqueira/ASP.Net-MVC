using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiSelvagem.Aplicacao;
using TiSelvagem.Dominio;

namespace UserInterface.Dos
{
    class Program
    {
        static void Main(string[] args)
        {

            //var contexto = new Contexto();
            var alunoAplicacao = new AlunoAplicacao();


            //SqlConnectionStringBuilder sqlString = new SqlConnectionStringBuilder();

            //https://www.youtube.com/watch?v=bhUpZwzC3uU
            //sqlString.DataSource = @"MARIA\SQLEXPRESS";
            //sqlString.InitialCatalog = " FaculdadeTISelvagem";
            //sqlString.UserID = "t_siqueira";
            //sqlString.Password = "progresso";

            //sqlString.DataSource = "logusdb.database.windows.net";
            //sqlString.InitialCatalog = "LogusCapital";
            //sqlString.UserID = "logus";
            //sqlString.Password = "Geh4Datenbank";

            //Console.WriteLine(sqlString.ConnectionString);

            //SqlConnection conn = new SqlConnection(sqlString.ConnectionString);
            //conn.Open();

            //listar
            //string strQuerySelect = "SELECT * FROM ALUNO";
            //SqlCommand cmdComandoSelect = new SqlCommand(strQuerySelect, conn);
            //SqlDataReader dados = cmdComandoSelect.ExecuteReader();

            //atualizar
            // string strQueryUpdate = "UPDATE ALUNO SET Nome = 'Nome Atualizado' WHERE AlunoId = 4";
            // SqlCommand cmdComandoUpdate = new SqlCommand(strQueryUpdate, conn);
            //  cmdComandoUpdate.ExecuteNonQuery();

            //apagar
            //  string strQueryDelete = "DELETE FROM ALUNO WHERE AlunoId = 4";
            //   SqlCommand cmdComandoDelete = new SqlCommand(strQueryDelete, conn);
            //   cmdComandoDelete.ExecuteNonQuery();


            var appAluno = new AlunoAplicacao();

            //criar
            Console.Write("Digite o nome do aluno: ");
            String nome = Console.ReadLine();

            Console.Write("Digite o nome da mae do aluno: ");
            String mae = Console.ReadLine();

            Console.Write("Digite a data de nascimento do aluno: ");
            String data = Console.ReadLine();

            

            var aluno1 = new Aluno
            {
                Nome = nome,
                Mae = mae,
                DataNascimento = DateTime.Parse(data)
            };

            // new AlunoAplicacao().Insert(aluno);
            //aluno1.Id = 13;
            appAluno.Salvar(aluno1);

           // new AlunoAplicacao().Excluir(15);



            //alunoAplicacao.Insert(nome, mae, data);

            //new AlunoAplicacao().Insert(nome, mae, data);


            //string strQueryInsert = string.Format("INSERT INTO ALUNO (Nome, Mae, DataNascimento) VALUES ('{0}','{1}','{2}')", nome, mae, data);            
            //contexto.ExecutaComando(strQueryInsert);

            //SqlCommand cmdComandoInsert = new SqlCommand(strQueryInsert, conn);
            //cmdComandoInsert.ExecuteNonQuery();

            //listar
            //string strQuerySelect = "SELECT * FROM ALUNO";
            //SqlDataReader dados = contexto.ExecutaComandoComRetorno(strQuerySelect);
            var dados = appAluno.ListarTodos();

            //SqlCommand cmdComandoSelect = new SqlCommand(strQuerySelect, conn);
            //SqlDataReader dados = cmdComandoSelect.ExecuteReader();

            foreach( var aluno in dados)
            {
                Console.WriteLine("Id:{0}, Nome:{1}, Mae:{2}, DataNascimento:{3}",aluno.Id,aluno.Nome,aluno.Mae,aluno.DataNascimento);
            }
            /*
            while (dados.Read())
            {
                Console.WriteLine("Id:{0}, Nome:{1}, Mae:{2}, DataNascimento:{3}",dados["AlunoId"], dados["Nome"], dados["Mae"],dados["DataNascimento"]);
            }
            */

        }
    }
}

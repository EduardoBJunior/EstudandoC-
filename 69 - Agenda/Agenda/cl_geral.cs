using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Agenda
{
    public static class cl_geral
    {
        public static string versao = "v1.0.0.0";

        //lista de contato
        public static List<cl_contato> lista_contatos;
        
        public static void ConstroiListaContatos()
        {
            //métodos para carregar a listade contato

            //verificar se o ficheiro existe
            string pasta_documentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string nome_ficheiro = pasta_documentos + @"\ficheiro_contato.txt";
            //cria a lista vazia
            lista_contatos = new List<cl_contato>();

            if (File.Exists(nome_ficheiro))
            {
                StreamReader ficheiro = new StreamReader(nome_ficheiro,Encoding.Default);
                lista_contatos = new List<cl_contato>();

                while (!ficheiro.EndOfStream)
                {
                    //carrga nome
                    string nome = ficheiro.ReadLine();
                    //carrega numero
                    string numero = ficheiro.ReadLine();

                    //adicionar a lista de Contatos o Cotato Carregado

                    cl_contato novo_contato = new cl_contato();
                    novo_contato.nome = nome;
                    novo_contato.numero = numero;

                    lista_contatos.Add(novo_contato);

                }
                ficheiro.Dispose();
            }
        }

    }

    
}

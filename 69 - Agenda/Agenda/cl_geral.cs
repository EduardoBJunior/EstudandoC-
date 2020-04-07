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
        //=============================================================================================
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
        //=============================================================================================
        public static void GravarNovoResgistro(string _nome,string _numero) 
        {
            //gravar um novo registro (na lista e no ficheiro) - modo compacto
            lista_contatos.Add(new cl_contato() { nome = _nome, numero = _numero });

            // a linha de cima é a mesma coisa que 
            //cl_contato novoContato = new cl_contato();
            //novoContato.nome = _nome;
            //novoContato.numero = _numero;

            // atualiza o ficheiro (o arquivo) 
            GravarFicheiro();
        }
        //=============================================================================================
        public static void GravarFicheiro()
        {
            string pasta_documentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string nome_ficheiro = pasta_documentos + @"\ficheiro_contato.txt";

            StreamWriter fichero = new StreamWriter(nome_ficheiro, false, Encoding.Default);

            foreach(cl_contato contato in lista_contatos)
            {
                fichero.WriteLine(contato.nome);
                fichero.WriteLine(contato.numero);
            }

            fichero.Dispose();
            
        }
        //=============================================================================================
        public static cl_contato BuscarContatoLista(int index)
        {
            var contato = lista_contatos[index];
            return contato;
        }
        //=============================================================================================
        public static void IserirContatoLista(string nome, string numero, int index)
        {
            //atualiza o registro na lista e na base de dados
            var contato = new cl_contato() { nome = nome, numero = numero };
            lista_contatos[index].nome = nome;
            lista_contatos[index].numero = numero;
        }

      

    }


}

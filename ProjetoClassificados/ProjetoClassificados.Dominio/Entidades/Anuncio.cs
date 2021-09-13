using Flunt.Notifications;
using Flunt.Validations;
using ProjetoClassificados.Comum.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoClassificados.Dominio.Entidades
{
    public class Anuncio : Entidade
    {

        public Anuncio(string nome, string descricao, string imagem, float preco)
        {
            AddNotifications(
            new Contract<Notification>()
                .Requires()
                .IsNotEmpty(nome, "Nome", "Nome não pode ser vazio")
                .IsNotEmpty(descricao, "Descricao", "Descricao não pode ser vazia")
            );

            if (IsValid)
            {
                Nome = nome;
                Descricao = descricao;
                Imagem = imagem;
                Preco = preco;
            }

        }

        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public string Imagem { get; private set; }
        public float Preco { get; private set; }

        // Composicões ? id do usuario q postou o anuncio

        // public Guid idUsuario { get; private set; }
        // public virtual Usuario Usuario { get; private set; }


        public void AtualizaAnuncio(string descricao, string imagem, float preco)
        {
            AddNotifications(
            new Contract<Notification>()
                .Requires()
                .IsNotEmpty(descricao, "Descrição", "Descrição não pode ser vazia")
            );

            if (IsValid)
            {
                Descricao = descricao;
                Imagem = imagem;
                Preco = preco;
            }

        }


    }
}

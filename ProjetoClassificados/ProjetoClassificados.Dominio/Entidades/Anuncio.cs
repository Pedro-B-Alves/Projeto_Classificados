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

        public Anuncio(string nome, string descricao, string imagem, float preco /*Guid idUsuario*/)
        {
            AddNotifications(
            new Contract<Notification>()
                .Requires()
                .IsNotEmpty(nome, "Nome", "Nome não pode ser vazio")
                .IsNotEmpty(descricao, "Descricao", "Descricao não pode ser vazia")
                .IsNotNull(preco, "Preco", "Preço não pode ser vazio")
                //.IsNotNull(idUsuario, "IdUsuario", "Id do Usuario não pode ser vazio")
            );

            if (IsValid)
            {
                Nome = nome;
                Descricao = descricao;
                Imagem = imagem;
                Preco = preco;
                //IdUsuario = idUsuario;
            }

        }

        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public string Imagem { get; private set; }
        public float Preco { get; private set; }
        public Guid IdAnuncio { get; set; }

        // Composições
        // public Guid IdUsuario { get; private set; }
        // public virtual Usuario Usuario { get; private set; }
        public IReadOnlyCollection<Interesse> Inteesses { get; private set; }

        public void AtualizaAnuncio(string nome, string descricao, string imagem, float preco /*Guid idUsuario*/)
        {
            AddNotifications(
            new Contract<Notification>()
                .Requires()
                .IsNotEmpty(nome, "Nome", "Nome não pode ser vazio")
                .IsNotEmpty(descricao, "Descrição", "Descrição não pode ser vazia")
                .IsNotEmpty(imagem, "Imagem", "Imagem não pode ser vazia")
                .IsNotNull(preco, "Preço", "O preço não pode ser vazio")
                //.IsNotNull(idUsuario, "IdUsuario", "IdUsuario não pode ser vazio")
            );

            if (IsValid)
            {
                Nome = nome;
                Descricao = descricao;
                Imagem = imagem;
                Preco = preco;
                //IdUsuario = idUsuario;
            }

        }


    }
}

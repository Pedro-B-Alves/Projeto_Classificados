using Flunt.Notifications;
using Flunt.Validations;
using ProjetoClassificados.Comum.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoClassificados.Dominio.Commands.Anuncio
{
    class CriarAnuncioCommand : Notifiable<Notification>, ICommand
    {

        public CriarAnuncioCommand()
        {

        }

        public CriarAnuncioCommand(string nome, string descricao, string imagem, float preco)
        {
            Nome = nome;
            Descricao = descricao;
            Imagem = imagem;
            Preco = preco;
        }

        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }
        public float Preco { get; set; }


        public void Validar()
        {
            AddNotifications(
            new Contract<Notification>()
                .Requires()
                .IsNotEmpty(Nome, "Nome", "Nome não pode ser vazio")
                .IsNotEmpty(Descricao, "Descrição", "Descrição não pode ser vazia")
            );
        }

    }
}

using Flunt.Notifications;
using Flunt.Validations;
using ProjetoClassificados.Comum.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoClassificados.Dominio.Commands.Autenticacao
{
    public class PostarCommand : Notifiable<Notification>, ICommand
    {

        public PostarCommand(string nome, float preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public string Nome { get; set; }
        public float Preco { get; set; }

        public void Validar()
        {
            AddNotifications(
            new Contract<Notification>()
                .Requires()
                .IsNotEmpty(Nome, "Nome", "O nome não pode estar vazio")
                .IsNotNull(Preco, "Preco", "O preço não pode estar vazio")
            );
        }

    }
}

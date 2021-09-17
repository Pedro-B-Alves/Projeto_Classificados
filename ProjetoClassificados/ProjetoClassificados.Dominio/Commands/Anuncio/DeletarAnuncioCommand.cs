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
    public class DeletarAnuncioCommand : Notifiable<Notification>, ICommand
    {

        public DeletarAnuncioCommand()
        {

        }

        public DeletarAnuncioCommand(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }

        public void Validar()
        {
            AddNotifications(
            new Contract<Notification>()
                .Requires()
                .IsNotNull(Id, "Id", "O Id não pode ser vazio")
            );
        }

    }
}

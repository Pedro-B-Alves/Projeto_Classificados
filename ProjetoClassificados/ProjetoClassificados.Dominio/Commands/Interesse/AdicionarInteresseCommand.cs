using Flunt.Notifications;
using Flunt.Validations;
using ProjetoClassificados.Comum.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoClassificados.Dominio.Commands.Interesse
{
    public class AdicionarInteresseCommand : Notifiable<Notification>, ICommand
    {

        public Guid IdUsuario { get;  set; }
        public Guid IdAnuncio { get;  set; }


        public void Validar()
        {
            AddNotifications(
           new Contract<Notification>()
               .Requires()

               .IsNotNull(IdUsuario, "IdUsuario", "Id do Usuario não pode ser vazio")
               .IsNotNull(IdAnuncio, "IdAnuncio", "Id do Anuncio não pode ser vazio")
           );
        }
    }
}

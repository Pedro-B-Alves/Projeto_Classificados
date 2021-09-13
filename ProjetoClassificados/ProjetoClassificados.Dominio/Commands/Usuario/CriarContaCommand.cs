using Flunt.Notifications;
using Flunt.Validations;
using ProjetoClassificados.Comum.Commands;
using ProjetoClassificados.Comum.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoClassificados.Dominio.Commands.Usuario
{
    public class CriarContaCommand : Notifiable<Notification>, ICommand
    {
        public CriarContaCommand()
        {

        }

        public CriarContaCommand(string email, string senha, string nome, long telefone, string image, string cidade, string estado, EnTipoUsuario tipoUsuario)
        {
            Email = email;
            Senha = senha;
            Nome = nome;
            Telefone = telefone;
            Image = image;
            Cidade = cidade;
            Estado = estado;
            TipoUsuario = tipoUsuario;
        }

        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public long Telefone { get; set; }
        public string Image { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public EnTipoUsuario TipoUsuario { get; set; }

        public void Validar()
        {
            AddNotifications(
            new Contract<Notification>()
                .Requires()
                .IsEmail(Email, "Email", "formato incorreto de email")
                .IsGreaterThan(Senha, 8, "Senha", "A senha deve ter mais de 8 caracteres")
                .IsNotEmpty(Nome, "Nome", "Nome não pode ser vazio")
                .IsNotNull(Telefone, "Telefone", "telefone não pode ser vazio")
                .IsNotEmpty(Cidade, "Cidade", "Cidade não pode ser vazio")
                .IsNotEmpty(Estado, "Estado", "Estado não pode ser vazio")
            );
        }
    }
}

using Flunt.Notifications;
using Flunt.Validations;
using ProjetoClassificados.Comum.Entidade;
using ProjetoClassificados.Comum.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoClassificados.Dominio.Entidades
{
    public class Usuario : Entidade
    {
        public Usuario(string email, string senha, string nome, long telefone, string image, string cidade, string estado, EnTipoUsuario tipoUsuario)
        {

            AddNotifications(
            new Contract<Notification>()
                .Requires()
                .IsEmail(email, "Email", "formato incorreto de email")
                .IsGreaterThan(senha, 8, "Senha", "A senha deve ter mais de 8 caracteres")
                .IsNotEmpty(nome, "Nome", "Nome não pode ser vazio")
                .IsNotNull(telefone, "Telefone", "telefone não pode ser vazio")
                .IsNotEmpty(cidade, "Cidade", "Cidade não pode ser vazio")
                .IsNotEmpty(estado, "Estado", "Estado não pode ser vazio")
            );

            if (IsValid)
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
        }

        public string Email { get; private set; }
        public string Senha { get; private set; }
        public string Nome { get; private set; }
        public long Telefone { get; private set; }
        public string Image { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }
        public EnTipoUsuario TipoUsuario { get; private set; }

        public IReadOnlyCollection<Interesse> Inteesses { get; set; }


        // Composições 
        public IReadOnlyCollection<Anuncio> Anuncios { get; private set; }

        public void AtualizaUsuario(string email, string nome, long telefone, string image, string cidade, string estado)
        {
            AddNotifications(
            new Contract<Notification>()
                .Requires()
                .IsEmail(email, "Email", "formato incorreto de email")
                .IsNotEmpty(nome, "Nome", "Nome não pode ser vazio")
                .IsNotNull(telefone, "Telefone", "telefone não pode ser vazio")
                .IsNotEmpty(cidade, "Cidade", "Cidade não pode ser vazio")
                .IsNotEmpty(estado, "Estado", "Estado não pode ser vazio")
            );

            if (IsValid)
            {
                Nome = nome;
                Email = email;
                Telefone = telefone;
                Image = image;
                Cidade = cidade;
                Estado = estado;
            }
        }
    }
}

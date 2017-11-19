using System;
using SQLite.Net.Attributes;

namespace InovaCity_Serra.Model
{
    public class Usuario
    {
        private Int32 id;
        private string nome;
        private string email;
        private string sexo;
        private string senha;
        private string celular;
        private string cpf;
        private DateTime dataNascimento= DateTime.Today;
        private string rua;
        private string numero;
        private string cidade;
        private string estado;

        //Getters and Setters
        [PrimaryKey, AutoIncrement]
        public int Id { get => id; set => id = value; }
        [NotNull, MaxLength(50)]
        public string Nome { get => nome; set => nome = value; }
        [NotNull, MaxLength(50), Unique]
        public string Email { get => email; set => email = value; }
        [NotNull, MaxLength(12)]
        public string Senha { get => senha; set => senha = value; }
        [NotNull, MaxLength(11)]
        public string Celular { get => celular; set => celular = value; }
        [NotNull, MaxLength(11), Unique]
        public string Cpf { get => cpf; set => cpf = value; }
        public DateTime DataNascimento { get => dataNascimento; set => dataNascimento = value; }
        public string Rua { get => rua; set => rua = value; }
        public string Numero { get => numero; set => numero = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Sexo { get => sexo; set => sexo = value; }

        public Usuario()
        {
            nome = "";
            email = "";
            senha = "";
            celular = "";
            cpf = "";
            rua = "";
            numero = "";
            cidade = "";
            estado = "";
        }

        public override string ToString()
        {
            return string.Format("{0} - {1},  {3}, {2},{4},pass:{5},CPF:{6},{7},{8},Nº{9},{10},{11}", Id, Nome,Celular, Email,Sexo,Senha, Cpf,
                DataNascimento,Rua,Numero,Cidade,Estado);
        }
    }
}

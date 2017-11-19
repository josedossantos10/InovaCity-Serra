using System;
using System.Collections.Generic;
using System.Text;

namespace InovaCity_Serra.Model
{
    class User
    {
        private Int32 id;
        private string nome;
        private string cidade;
        private int sexo;


        //Getters and Setters
        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Saudacao { get => "Bem-vindo "+nome; }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace InovaCity_Serra.Model
{
    class Publicacao
    {
        private String descricao;
        private DateTime dataPublicacao;
        private Int32 votosFavor;
        private Int32 votosContra;
        private Int32 denuncias;
        private Int32 quantidadeCompartilhamento;
        private double latitude;
        private double longitude;
        private String[] fotos;
        private int status;



        //Geters e setters
        public string Descricao { get => descricao; set => descricao = value; }
        public int VotosFavor { get => votosFavor; set => votosFavor = value; }
        public int VotosContra { get => votosContra; set => votosContra = value; }
        public int Denuncias { get => denuncias; set => denuncias = value; }
        public int QuantidadeCompartilhamento { get => quantidadeCompartilhamento; set => quantidadeCompartilhamento = value; }
        public double Latitude { get => latitude; set => latitude = value; }
        public double Longitude { get => longitude; set => longitude = value; }
        public string[] Fotos { get => fotos; set => fotos = value; }
    }
}

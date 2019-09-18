using System;
using System.Collections.Generic;
using System.Text;

//GREICI EVANI DE SOUZA - RA: 2019102652

namespace TrabProg_1Bim
{
    class Cadastro
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }



        public override string ToString()
        {
            return "ID: " + Id + ", Nome: " + Nome + ", Telefone: " + Telefone;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Funcionamento_Celular
{
    public class Celular
    {
        //propriedades
        public string Cor;
        public string Modelo;
        public string Tamanho; 
        public bool Ligado = false;
    
         //métodos

        public bool Ligar()
        {
            if (Ligado == false)
            {
                Console.Clear();
                Console.WriteLine($"O aparelho está sendo ligado");
                Ligado = true;
                return Ligado;
            }

            else
            {
                Console.WriteLine($"O aparelho já está ligado !");
                return Ligado;
            }
        }

        
        public bool Desligar()
        {
            if (Ligado == true)
            {
                Console.Clear();
                Console.WriteLine($"O aparelho está sendo desligado");
                Ligado = false;
                return Ligado;
            }

            else
            {
                Console.WriteLine($"O aparelho já está ligado !");
                return Ligado;
            }

        }














    }

}
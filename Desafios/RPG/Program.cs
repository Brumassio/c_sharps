using System;
using Desafios.src.Entities;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight hero = new Knight("Joseph",12,"Knight",100,80,12);
            Wizard wizard = new Wizard("Geni", 88, "White Wizard",85,150,30);
            Ninja legoNinjago = new Ninja("Sonic Velocidade do Som",50,"Ninja Renegado",120,10,50);
            Console.WriteLine(wizard.Attack(5));
            Console.WriteLine(wizard.Attack(8));
            Console.WriteLine(hero.Attack());
            Console.WriteLine(legoNinjago.Attack(0));
            Console.WriteLine(legoNinjago.Attack(1));
            Console.WriteLine(legoNinjago.Attack(2));
            Console.WriteLine(wizard.ConsultHP());
            Console.WriteLine(legoNinjago.ConsultHP());
            Console.WriteLine(hero.ConsultHP());
            Console.WriteLine(wizard.ConsultMP());
            Console.WriteLine(legoNinjago.ConsultMP());
            Console.WriteLine(hero.ConsultMP());
        }
    }
   
}
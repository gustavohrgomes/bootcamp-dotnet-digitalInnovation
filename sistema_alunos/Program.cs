﻿using System;

namespace sistema_alunos
{
    class Program
    {
        static void Main(string[] args)
      {
         string opcaoUsuario = ObterOpcaoUsuario();

         while (opcaoUsuario.ToUpper() != "X")
         {

            switch (opcaoUsuario)
            {
               case "1":

                  break;

               case "2":

                  break;

               case "3":

                  break;

               default:
                  throw new ArgumentOutOfRangeException();
            }

            opcaoUsuario = ObterOpcaoUsuario();
         }
      }

      private static string ObterOpcaoUsuario()
      {
         Console.WriteLine("Informe a opção desejada: ");
         Console.WriteLine("1) Inserir Novo Aluno");
         Console.WriteLine("2) Listar Alunos");
         Console.WriteLine("3) Calcular média geral");
         Console.WriteLine("X) Sair");
         Console.WriteLine();

         string opcaoUsuario = Console.ReadLine();
         return opcaoUsuario;
      }
   }
}
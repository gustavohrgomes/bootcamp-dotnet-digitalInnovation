using System;

namespace sistema_alunos
{
    class Program
    {
        static void Main(string[] args)
      {

         Aluno[] alunos = new Aluno[5];
         int indiceAluno = 0;
         string opcaoUsuario = ObterOpcaoUsuario();

         while (opcaoUsuario.ToUpper() != "X")
         {

            switch (opcaoUsuario)
            {
               case "1":
                  
                  Console.Write("Informe o nome do aluno: ");
                  Aluno aluno = new Aluno();
                  aluno.Nome = Console.ReadLine();

                  Console.Write("Informe a nota do aluno: ");
                  
                  
                  if (double.TryParse(Console.ReadLine(), out double nota))
                  {
                     aluno.Nota = nota;
                  }
                  else
                  {
                      throw new ArgumentException("O valor da nota deve ser decimal!");
                  }

                  alunos[indiceAluno] = aluno;
                  indiceAluno++;

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
         Console.WriteLine();
         Console.WriteLine("Informe a opção desejada: ");
         Console.WriteLine("1) Inserir Novo Aluno");
         Console.WriteLine("2) Listar Alunos");
         Console.WriteLine("3) Calcular média geral");
         Console.WriteLine("X) Sair");
         Console.WriteLine();

         string opcaoUsuario = Console.ReadLine();
         Console.WriteLine();
         return opcaoUsuario;
      }
   }
}

string[,] alunos = new string[5, 7];
int l, c;
l = 0;
c = 0;  

for (l =0; l<= 4; l++)
{
    Console.WriteLine("Nome do aluno:");
    alunos[l, c++] = Console.ReadLine();
    Console.WriteLine("aulas dadas:");
    alunos[l, c++] = Console.ReadLine();
    Console.WriteLine("faltas do aluno");
    alunos[l, c++] = Console.ReadLine();
    Console.WriteLine("Nome da prova 1 :");
    alunos[l, c++] = Console.ReadLine();
    Console.WriteLine("Nome da prova 2 :");
    alunos[l, c++] = Console.ReadLine();
    Console.WriteLine("Nome da prova 3 :");
    alunos[l, c++] = Console.ReadLine();
    Console.WriteLine("Nota do trabalho :");
    alunos[l, c++] = Console.ReadLine();

}



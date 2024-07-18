namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = [-1, 6, 6, 21, 32, 10, 15, 13, 17, 22];
            int[] array2 = [-26, 4, 4, 7, 8, 3, 1, 23, 45, 9];

            int diferencaFinal = array1[0] - array2[0];

            if (diferencaFinal < 0) { diferencaFinal = -diferencaFinal; }

            for (int i = 0; i < array1.Length; i++)
            {   
                for (int j = 1; j < array2.Length; j++)
                {   
                    int diferenca = array2[i] - array1[j];

                    if (diferenca < 0)
                    {
                        diferenca = -diferenca;

                        if (diferenca < diferencaFinal) { diferencaFinal = diferenca; }
                    }
                    else 
                    {
                        if (diferenca < diferencaFinal) { diferencaFinal = diferenca; }
                    }
                }
            }
            Console.WriteLine(diferencaFinal);
        }
    }
}

namespace EjercicioArray2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] vocales = new char[5];
            vocales[0]= 'a';
            vocales[1]= 'e';
            vocales[2]= 'i';
            vocales[3]= 'o';
            vocales[4]= 'u';

            char[] vocales2 = new char[5];
            vocales2[0] = 'a';
            vocales2[1] = 'e';
            vocales2[2] = 'i';
            vocales2[3] = 'o';
            vocales2[4] = 's';


            bool buscarCons= false;
            for (int fila = 0; fila < vocales2.Length; fila++)
            {
                buscarCons = false;
                for(int columna=0; columna<vocales.Length; columna++)
                {
                    if (vocales2[fila] == vocales[columna])
                    {
                        buscarCons= true;
                        break;
                    }
                }

                if (!buscarCons)
                {
                    Console.WriteLine("La consonante que busca está en la " + fila  + " y su valor es " + vocales2[fila]);
                }
            }

        }
    }
}
   
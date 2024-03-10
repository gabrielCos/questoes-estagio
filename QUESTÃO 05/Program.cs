 class Program
{
    static void Main()
    {
        Console.Write("Digite uma string: ");
        string enter = Console.ReadLine();

        string resultadoInvertido = InverterString(enter);

        Console.WriteLine("String Invertida: " + resultadoInvertido);

        // Manter a janela do console aberta
        Console.ReadLine();
    }

    static string InverterString(string input)
    {
        char[] caracteres = input.ToCharArray();
        int first = 0;
        int last = caracteres.Length - 1;

        while (first < last)
        {
            char inv = caracteres[first];
            caracteres[first] = caracteres[last];
            caracteres[last] = inv;

            first++;
            last--;
        }
        return new string(caracteres);
    }
}
 
 


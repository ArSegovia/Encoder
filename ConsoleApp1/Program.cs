string? texto = Console.ReadLine();

if (texto != null)
{   
    texto = String.Concat(texto.Where(c => !Char.IsWhiteSpace(c)));
    int len = texto.Length;
    double raiz = Math.Sqrt(len); 
    double piso = Math.Floor(raiz);
    double techo = Math.Ceiling(raiz);
    int num = 0;

    for (int i = (int)piso; i <= (int)techo; i++)
    {
        if (i * i >= len)
        {
            num = i;
            break;
        }
    }

    string[] tabla1 = texto
    .Chunk(num)
    .Select(x => new string(x))
    .ToArray();

    for (int i = 0; i < num; i++)
    {
        foreach (string s in tabla1)
        {
            int cant = s.Length;
            if (i < cant)                
                Console.Write(s[i]);
        }
        Console.Write(" ");
    }   
}





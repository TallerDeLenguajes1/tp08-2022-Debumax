// See https://aka.ms/new-console-template for more information
Console.WriteLine("haciendo la wea esta ");


string rutaCarpeta=@"..\tp08-2022-Debumax";

List<string> listaDeContenido=Directory.GetFiles(rutaCarpeta).ToList();
Console.WriteLine($"la ruta es : {rutaCarpeta}");
foreach (string archivos in listaDeContenido)
{
 
    Console.WriteLine(archivos);
}

string archivo = rutaCarpeta+@"\index.txt";
if (!File.Exists(archivo))
{
    File.Create(archivo);
}
Console.WriteLine("leyendo el archivo");

string texto=File.ReadAllText(archivo);
Console.WriteLine($"lo que contiene el archivo {texto} ");



Console.WriteLine("escribiendo el archivo");
File.WriteAllLines(archivo,listaDeContenido);
Console.WriteLine("fin de escritura");
// See https://aka.ms/new-console-template for more information
Console.WriteLine("haciendo la wea esta ");


string rutaCarpeta=@"..\tp08-2022-Debumax";

List<string> listaDeContenido=Directory.GetFiles(rutaCarpeta).ToList();
Console.WriteLine($"la ruta es : {rutaCarpeta}");
foreach (string archivos in listaDeContenido)
{
 
    Console.WriteLine(archivos);
}

string archivo = rutaCarpeta+@"\index.csv";
if (!File.Exists(archivo))
{
    File.Create(archivo);
}
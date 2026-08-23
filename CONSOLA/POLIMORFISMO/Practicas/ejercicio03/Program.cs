//Lista polimorfica de Animales: Lista de tipo Animal con Perro, Gato y Vaca. Recorra y llame a HacerSonido().

using ejercicio03;

Console.WriteLine("=== SONIDO DE ANIMALES ===");

//Lista para guardar los animales
List<Animal> list = new List<Animal>();
list.Add(new Perro());
list.Add(new Gato());
list.Add(new Vaca());

//Salida
foreach (Animal item in list)
{
    item.HacerSonido();
}
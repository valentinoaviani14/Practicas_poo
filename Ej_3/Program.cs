using Ej_3;
using System;

IJugador pibe = new Amateur();

Console.WriteLine("Amateur");
Console.WriteLine("¿Pudo correr 15 min?: " + pibe.correr(20));
Console.WriteLine("¿Está cansado?: " + pibe.cansado()); 

Console.WriteLine("¿Pudo correr 10 min más?: " + pibe.correr(10)); 
Console.WriteLine("¿Está cansado?: " + pibe.cansado()); 

pibe.descansar(1);
Console.WriteLine("¿Pudo correr después de descansar?: " + pibe.correr(5)); 

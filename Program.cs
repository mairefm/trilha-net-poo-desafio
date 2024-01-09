using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone - Feito!
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia1 = new Nokia(numero: "(11)97355-6513", modelo: "M8956", imei: "I4523MEI", memoria: 128);
nokia1.Ligar();
nokia1.InstalarAplicativo("Instagram");


Console.WriteLine("\n------------------------------------\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone1 = new Iphone(numero: "(11)99826-2598", modelo: "M5269", imei: "I254MEI", memoria: 256);
iphone1.Ligar();
iphone1.InstalarAplicativo("FITI");



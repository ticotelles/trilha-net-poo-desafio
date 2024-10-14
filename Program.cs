using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia");
Nokia nokia = new Nokia("321321", "nokia 3310", "1111111", 128);

nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");


Iphone iphone = new Iphone("5858442", "Iphone 15 Pro MAx", "2222222", 512);
Console.WriteLine("Smartphone Iphone");
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Nubank");

//numero: "252525", modelo: 01, imei: "01010101", memoria: 12
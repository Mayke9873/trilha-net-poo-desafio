using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia n1 = new Nokia("(11) 9-1111-1111", "Nokia 9", "123456789", 16);
n1.ApresentarAparelho();
n1.Ligar();
n1.ReceberLigacao();
n1.InstalarAplicativo("WhatsAPP");

Console.WriteLine("\n");

Iphone p1 = new Iphone("(11) 1-9999-9999", "iPhone SE 2018", "987654321", 128);
p1.ApresentarAparelho();
p1.Ligar();
p1.ReceberLigacao();
p1.InstalarAplicativo("WhatsAPP");
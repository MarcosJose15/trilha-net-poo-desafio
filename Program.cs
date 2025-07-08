using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia Nok1 = new Nokia("123456", "Nokia-S", "C4:G4:B4:C6", 500);
Iphone Iphone1 = new Iphone("123477", "Iphone-XS", "C7:G7:B7:C7", 500);

Nok1.Ligar();
Iphone1.Ligar(); 
Nok1.ReceberLigacao();
Iphone1.ReceberLigacao();
Nok1.InstalarAplicativo("NETFLIX APP");
Iphone1.InstalarAplicativo("APPLE APP");
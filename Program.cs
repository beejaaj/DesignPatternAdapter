using Adapter_14_04_25;

List<Poligono> polígonos = new List<Poligono>();

// Adicionando polígonos à lista
polígonos.Add(new Quadrado(5.0));       // Área: 25
polígonos.Add(new Triangulo(4.0, 3.0)); // Área: 6
                                        // Criando e adaptando o hexágono estrangeiro
HexagonoEstrangeiro hexEstrangeiro = new HexagonoEstrangeiro(2.0); // Área: ~10.3923
polígonos.Add(new AdaptadorHexagono(hexEstrangeiro));

// Calculando e exibindo áreas de forma polimórfica
foreach (var poligono in polígonos)
{
    Console.WriteLine($"Área do polígono: {poligono.getArea():F4}");
}

/*
Saída esperada:
Área do polígono: 25,0000
Área do polígono: 6,0000
Área do polígono: 10,3923
*/
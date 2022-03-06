// See https://aka.ms/new-console-template for more information
using ListaEncadeada;

static void Main(string[] args)
{
    var gerenteDoTrem = new GerenteDoTrem();

    InserirVagoesNoTrem(gerenteDoTrem);
    ImprimeTodosOsVagoes(gerenteDoTrem);
    AtualizaVagao(gerenteDoTrem);
    ImprimeTodosOsVagoes(gerenteDoTrem);
    DeletaVagao(gerenteDoTrem);
    ImprimeTodosOsVagoes(gerenteDoTrem);
}

 static void InserirVagoesNoTrem(GerenteDoTrem gerenteDoTrem)
{
    var vagao01 = new Vagao() { Id = 123, Carga = "Pedras", PesoEmToneladas = 15 };
    var vagao02 = new Vagao() { Id = 234, Carga = "Tabuas", PesoEmToneladas = 1 };
    var vagao03 = new Vagao() { Id = 345, Carga = "imas", PesoEmToneladas = 9 };
    var vagao04 = new Vagao() { Id = 456, Carga = "Cadeiras", PesoEmToneladas = 4 };
    var vagao05 = new Vagao() { Id = 567, Carga = "portas", PesoEmToneladas = 5 };

    gerenteDoTrem.InserirVagao(vagao03);
    gerenteDoTrem.InserirVagao(vagao01);
    gerenteDoTrem.InserirVagao(vagao04);
    gerenteDoTrem.InserirVagao(vagao05);
    gerenteDoTrem.InserirVagao(vagao02);
}

 static void ImprimeTodosOsVagoes(GerenteDoTrem gerenteDoTrem)
{
    Console.WriteLine($"Escrevendo todos os vagoes do trem");
    foreach (var item in gerenteDoTrem.GetVagoes())
    {
        Console.WriteLine($"ID {item.Id} - Carga {item.Carga} - Peso {item.PesoEmToneladas}");
    }
    Console.WriteLine();
}

 static void AtualizaVagao(GerenteDoTrem gerenteDoTrem)
{
    var Vagao = new Vagao() { Id = 456, Carga = "Luzes", PesoEmToneladas = 7 };
    gerenteDoTrem.AtualizarVagao(Vagao);
}

 static void DeletaVagao(GerenteDoTrem gerenteDoTrem)
{
    gerenteDoTrem.DeletarVagao(345);
}
    


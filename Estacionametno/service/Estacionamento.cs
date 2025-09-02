using System.Runtime.Intrinsics.Arm;

namespace Estacionametno.service;

public class Estacionamento
{
    private List<Ficha> carrosList;
    private Decimal precoporhora;
    private Decimal precoInicial;
    
    
    public Estacionamento(Decimal precoporhora, Decimal precoinicial)
    {
        this.precoInicial =  precoinicial;
        this.precoporhora = precoporhora;
        carrosList = new List<Ficha>();
    }
    

    public void AdicionarPlaca(string placa,int horai, int horaf)
    {
        Ficha carro = carrosList.Find(ficha => ficha.Placa.Equals(placa));
        if (carro == null)
        {
            carrosList.Add(new Ficha(placa, horai, horaf));
            return;
        }

        Console.WriteLine("carrp existe");
    }

    public void RemoverPlaca(string placa)
    {
        if (carrosList.Count == 0)
        {
            Console.WriteLine("Nao tem carro");
        }

        Ficha carroremver = carrosList.Find(ficha => ficha.Placa.Equals(placa));

        if (carroremver == null)
        {
            Console.WriteLine("Nao tem esse carro");
        }
        else
        {
            Console.WriteLine(CalcularPrecoPorHora(carroremver.HorasTotal()));
            carrosList.Remove(carroremver);

        }
        

    }

    public void ListarPlacas()
    {
        foreach (var car in carrosList)
        {
            Console.WriteLine(car.ToString());
        }
    }


    private Decimal CalcularPrecoPorHora(int horas)
    {
        return precoInicial + (horas * precoporhora);
    }





}
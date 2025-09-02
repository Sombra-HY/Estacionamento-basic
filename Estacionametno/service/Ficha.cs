namespace Estacionametno.service;

public class Ficha
{
    private string placa;
    private int horaInicial;
    private int horaFinal;

    // Construtor completo
    public Ficha(string placa, int horaInicial, int horaFinal)
    {
        this.placa = placa ?? throw new ArgumentNullException(nameof(placa));
        this.horaInicial = horaInicial;
        this.horaFinal = horaFinal;
    }

    // Propriedades públicas
    public string Placa
    {
        get => placa;
        set => placa = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int HoraInicial
    {
        get => horaInicial;
        set => horaInicial = value;
    }

    public int HoraFinal
    {
        get => horaFinal;
        set => horaFinal = value;
    }

    // Calcula horas totais
    public int HorasTotal()
    {
        return horaFinal - horaInicial;
    }

    // Representação legível do objeto
    public override string ToString()
    {
        return $"Placa: {placa}, Entrada: {horaInicial}h, Saída: {horaFinal}h, Total: {HorasTotal()}h";
    }
}
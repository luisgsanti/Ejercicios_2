using Newtonsoft.Json;
namespace Practica_1.Models
{
    public class Impuesto
    {
        [JsonProperty("id")] public int Id { get; set; }
        [JsonProperty("numeroLiquidacion")] public int NumeroLiquidacion { get; set; }
        [JsonProperty("grados")] public int Grados { get; set; }
        [JsonProperty("valorImpuesto")] public int ValorImpuesto { get; set; }
        
    }
}
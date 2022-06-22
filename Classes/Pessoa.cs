using Back_End_5.Interfaces;

namespace Back_End_5.Classes
{
    public abstract class Pessoa: IPessoa
    {
         public string ?Nome { get; set; }
         public Endereco ?Endereco { get; set; }
         public float Rendimento { get; set; }
         
             public abstract float PagarImposto(float rendimento);
    }
}
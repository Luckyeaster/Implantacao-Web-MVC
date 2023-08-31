namespace LHPet.Models;

public class Fornecedor
{
    public int Id { get; set; }
   public string? Nome { get; set;}
   public string? Cnpj { get; set; }
   public string? Email { get; set; }
   public string? Paciente { get; set; }

    public Fornecedor(int id, string nome, string cnpj, string email, string paciente)
    {
        this.Id = id;
        this.Nome = nome;
        this.Cnpj = cnpj;
        this.Email = email;
        this.Paciente = paciente;
    }
}
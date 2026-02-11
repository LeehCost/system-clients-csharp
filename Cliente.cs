using System;
class Cliente
{
    public string Nome { get; set; } //propriedades do clientes = dados
    public string Email { get; set; }
//mostra os dados do cliente
    public Cliente(string nome, string email)
    {
        Nome = nome;
        Email = email;
    }

    public void Exibir()
    {
        Console.WriteLine($"Nome: {Nome} | Email: {Email}");
    }
}
using System;

namespace BuffetWeb.Models.Buffet.Cliente
{

 
    public class ClienteEntity
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime Inserido { get; set; }
        public DateTime UltimaMod { get; set; }
        public TipoClienteEntity TipoCliente { get; set; }
        public int Cpf { get; set; }
        public int Cnpj { get; set; }
        public DateTime DataNasimento { get; set; }
    }
}
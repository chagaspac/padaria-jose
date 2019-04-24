using System;

namespace PadariaJose.Models
{
    public class UsuarioViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; private set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string BirthDate { get; set; }

    }
}
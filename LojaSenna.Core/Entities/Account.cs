using System;

namespace LojaSenna.Core.Entities
{
    public class Account
    {
        public int Id { get; set; }

        // Login único (pode ser email ou username)
        public string Username { get; set; }

        // Armazene hash da senha (NUNCA plaintext)
        public string PasswordHash { get; set; }

        // Relacionamento com User (opcional)
        public int? UserId { get; set; }
        public User User { get; set; }

        // Controle básico
        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? LastLoginAt { get; set; }

        // Simples controle de roles (pode virar tabela própria se precisar)
        public string Role { get; set; } = "User";
    }
}


using Ecommerce.Entities.Utenti;
using Ecommerce.Entities.Utenti.CustomerDTO;

using Ecommerce.Repository.CustomerDTO;

namespace Ecommerce.Service.CustomerDTO
{
    public class ClienteDTOService : IClienteDTOService
    {
        private readonly IClienteDTORepository _clienteDTORepository;

        public ClienteDTOService(IClienteDTORepository _clienteDTORepository)
        {
           this._clienteDTORepository = _clienteDTORepository;
        }

        public async Task RegisterClienteAsync(ClienteDTO clienteDto)
        {
            if (clienteDto == null)
            {
                throw new ArgumentNullException(nameof(clienteDto), "Il DTO del cliente è nullo.");
            }
            // Check if the email is already registered
         var existingCliente = await _clienteDTORepository.GetClienteByEmailAsync(clienteDto.Email);

            if (existingCliente != null)
            {
                throw new Exception("Cliente con questa email esiste già.");
            }

            // Hash the password (you can use a library like BCrypt)
            var hashedPassword = HashPassword(clienteDto.Password);

            // Create a new Cliente object
            var newCliente = new Cliente
            {
                Nome = clienteDto.Nome,
                Cognome = clienteDto.Cognome,
                Email = clienteDto.Email,
                Password = hashedPassword,
                Indirizzo = clienteDto.Indirizzo
            };

            // Add the new customer to the database
            await _clienteDTORepository.AddClienteAsync(newCliente);
            await _clienteDTORepository.SaveChangesAsync();
        }

        private string HashPassword(string password)
        {
            // You can use BCrypt.Net-Next or any other hashing algorithm to hash passwords
            // return BCrypt.Net.BCrypt.HashPassword(password);
            return password;  // Plain text for demo purposes (Not recommended for production)
        }
        public ClienteDTO Login(string email, string password)
    {
        // Check if the user exists and the password is correct
        ClienteDTO clientedto = _clienteDTORepository.GetByEmail(email);
        if (clientedto != null && clientedto.Password == password) // Use a secure method for password checking in production
        {
            return clientedto;
        }

        return null; // Invalid credentials
    }
    }
}
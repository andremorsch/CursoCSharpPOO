namespace Aula71Hotel
{
    public class Quartos
    {
        public string Hospede { get; set; }
        public string Email { get; set; }

        public Quartos(string hospede, string email)
        {
            Hospede = hospede;
            Email = email;
        }

        public override string ToString()
        {
            return $"{Hospede}, {Email}";
        }
    }
}

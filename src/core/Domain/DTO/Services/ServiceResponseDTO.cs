namespace Domain.DTO.Services
{
    public class ServiceResponseDTO
    {
        public List<string> Messages { get; private set; }

        public bool Status { get; private set; }

        public ServiceResponseDTO(string message, bool status)
        {
            Messages = [message];
            Status = status;
        }

        public ServiceResponseDTO(bool status)
        {
            Messages = [];
            Status = status;
        }

        public ServiceResponseDTO(List<string> messages, bool status)
        {
            Messages = messages;
            Status = status;
        }
    }
}

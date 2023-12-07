using Domain.DTO.Services;
using Domain.Entities;

namespace Domain.Interfaces.Services
{
    public interface IUserService
    {
        Task<ServiceResponseDTO> ValidateSave(UserEntity userEntity);
    }
}

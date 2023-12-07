using Domain.DTO.Services;
using Domain.Entities;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Services;
using Services.Validators.User;

namespace Services.User
{
    public class UserService(IUserRepository userRepository) : IUserService
    {
        private readonly IUserRepository _userRepository = userRepository;
        public async Task<ServiceResponseDTO> ValidateSave(UserEntity userEntity)
        {
            try
            {
                var validator = new UserCreateValidator();
                var result = validator.Validate(userEntity);

                if (!result.IsValid)
                    return new ServiceResponseDTO(result.Errors.Select(e => e.ErrorMessage).ToList(), result.IsValid);

                var existingUser = await _userRepository.GetOneAsync(u => u.Email.Equals(userEntity.Email));
                if (existingUser is not null)
                    return new ServiceResponseDTO("Email já cadastrado", false);

                return new ServiceResponseDTO(result.IsValid);

            }catch(Exception ex)
            {
                throw new Exception("", new Exception(ex.Message));
            }
        }
    }
}

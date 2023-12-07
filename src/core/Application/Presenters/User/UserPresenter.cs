using Application.Request.User;
using Application.Response;
using Domain.Entities;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Services;

namespace Application.Presenters.User
{
    public class UserPresenter(IUserRepository userRepository,
        IUserService userService) : IUserPresenter
    {
        private readonly IUserRepository _userRepository = userRepository;
        private readonly IUserService _userService = userService;

        public async Task<PresenterResponse> SaveAsync(UserCreateOrUpdateRequest request)
        {
            try
            {
                UserEntity userEntity = new(request.Name, request.Email, request.Password);

                var result = await _userService.ValidateSave(userEntity);

                if (!result.Status)
                    return new PresenterResponse(result.Messages, result.Status);

                await _userRepository.AddAsync(userEntity);

                return new PresenterResponse("Usuario cadastrado com sucesso!", result.Status, userEntity);

            }catch (Exception ex)
            {
                throw new Exception("", new Exception(ex.Message));
            }
        }
    }
}

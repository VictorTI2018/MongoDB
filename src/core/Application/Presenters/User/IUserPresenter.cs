using Application.Request.User;
using Application.Response;

namespace Application.Presenters.User
{
    public interface IUserPresenter
    {
        Task<PresenterResponse> SaveAsync(UserCreateOrUpdateRequest request);
    }
}

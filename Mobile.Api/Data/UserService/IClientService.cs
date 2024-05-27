using Mobile.Data;

namespace Mobile.Api.Data.UserService
{
	public interface IClientService
	{
		Task<ServiceResponse> RegisterUserAsync(Registration model);
		Task<ServiceResponse> LoginUserAsync(Login model);
	}
}

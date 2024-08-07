using FilamentManufacturer.Domain.Models.Serial;

namespace FilamentManufacturer.Service.Services.Parameters
{
    public interface IParametersService
    {
        Task SaveParametersAsync(SerialParametersModel model);
        Task<SerialParametersModel> GetParametersAsync();
    }
}

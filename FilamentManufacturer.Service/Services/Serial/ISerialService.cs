using FilamentManufacturer.Domain.Enum.Serial;
using FilamentManufacturer.Domain.Models.Serial;

namespace FilamentManufacturer.Service.Services.Serial
{
    public interface ISerialService
    {
        event EventHandler ConnectedHandler;

        Task ConnectSerialPortAsync();
        Task<string> SendCommandSerialPortAsync(SerialCommandEnum command);
        Task<string> ReadInfosAsync();
    }
}

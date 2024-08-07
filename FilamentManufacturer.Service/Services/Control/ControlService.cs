using FilamentManufacturer.Service.Services.Serial;

namespace FilamentManufacturer.Service.Services.Control
{
    public class ControlService : IControlService
    {
        private readonly ISerialService _serial;

        public ControlService(ISerialService serial)
        {
            _serial = serial;
        }

        public async Task ReadSerialInfosAsync()
        {
            await _serial.ReadInfosAsync();
        }
    }
}

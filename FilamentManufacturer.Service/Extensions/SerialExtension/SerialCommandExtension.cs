using FilamentManufacturer.Domain.Enum.Serial;

namespace FilamentManufacturer.Service.Extensions.SerialExtension
{
    public static class SerialCommandExtension
    {
        public static string SerialCommandFormat(this SerialCommandEnum command)
        {
            var result = ((int)command).ToString();
            result = result.Length == 1 ? $"0{result}" : result;

            return result;
        }
    }
}

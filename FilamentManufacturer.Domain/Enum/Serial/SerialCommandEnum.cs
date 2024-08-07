namespace FilamentManufacturer.Domain.Enum.Serial
{
    public enum SerialCommandEnum
    {
        Identify = 0,
        StartAll = 1,
        StopAll = 2,
        StartHotend = 3,
        StopHotend = 4,
        StartEngine = 5,
        StopEngine = 6,
        EnableInfos = 7,
        DisableInfos = 8,
        DefineEngineRPM = 9,
        DefineTemperature = 10,
    }
}

namespace FilamentManufacturer.Domain.Models.Serial
{
    public class SerialParametersModel
    {
        public float Temperature { get; set; }
        public float EngineRPM { get; set; }

        public SerialParametersModel() { }

        public SerialParametersModel(float temperature, float engineRPM)
        {
            Temperature = temperature;
            EngineRPM = engineRPM;
        }
    }
}

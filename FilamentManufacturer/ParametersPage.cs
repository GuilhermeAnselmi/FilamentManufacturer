using FilamentManufacturer.Domain.Models.Serial;
using FilamentManufacturer.Service.Services.Parameters;

namespace FilamentManufacturer
{
    public partial class ParametersPage : Form
    {
        private readonly IParametersService _parameters;

        public ParametersPage(IParametersService parameters)
        {
            _parameters = parameters;

            InitializeComponent();

            DefineParametersAsync();
        }

        #region Internal Methods
        private async Task DefineParametersAsync()
        {
            var model = await _parameters.GetParametersAsync();

            txtTemperature.Text = model.Temperature.ToString();
            txtEngineRPM.Text = model.EngineRPM.ToString();
        }
        #endregion

        private async void Save(object sender, EventArgs e)
        {
            var temperature = txtTemperature.Text;
            var rpm = txtEngineRPM.Text;

            float temperatureOut;
            float rpmOut;

            if (!float.TryParse(temperature, out temperatureOut))
            {
                MessageBox.Show("Not Save!\n\"Temperature\" field can only contain numbers.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (!float.TryParse(rpm, out rpmOut))
            {
                MessageBox.Show("Not Save!\n\"Engine RPM\" field can only contain numbers.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            await _parameters.SaveParametersAsync(new SerialParametersModel(temperatureOut, rpmOut));

            DefineParametersAsync();

            Close();
        }

        private void Done(object sender, EventArgs e)
        {
            DefineParametersAsync();

            Close();
        }
    }
}

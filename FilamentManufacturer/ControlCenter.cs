using FilamentManufacturer.Service.Services.Control;
using FilamentManufacturer.Service.Services.Parameters;
using Microsoft.Extensions.DependencyInjection;

namespace FilamentManufacturer
{
    public partial class ControlCenter : Form
    {
        private readonly IServiceProvider _service;
        private readonly IControlService _control;
        private readonly IParametersService _parametersService;

        public ControlCenter(IServiceProvider service, IControlService control, IParametersService parametersService)
        {
            _service = service;
            _control = control;
            _parametersService = parametersService;

            InitializeComponent();

            InitalizeTaskUpdateInfos();
        }

        #region Internal Methods
        private void InitalizeTaskUpdateInfos()
        {
            Task.Run(_control.ReadSerialInfosAsync);
        }
        #endregion

        private void OpenParameters(object sender, EventArgs e)
        {
            var parameters = _service.GetRequiredService<ParametersPage>();
            parameters.ShowDialog();
        }
    }
}

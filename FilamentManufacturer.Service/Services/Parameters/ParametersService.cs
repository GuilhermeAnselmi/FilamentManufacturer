using FilamentManufacturer.Domain.Models.Serial;
using Newtonsoft.Json;

namespace FilamentManufacturer.Service.Services.Parameters
{
    public class ParametersService : IParametersService
    {
        public SerialParametersModel Model { get; private set; }

        private readonly string _path;
        private readonly string _filename;
        private readonly string _fullpath;

        public ParametersService(string path, string filename)
        {
            _path = path;
            _filename = $"{filename}.json";
            _fullpath = Path.Combine(_path, _filename);

            CreateFile();
        }

        #region Internal Methods
        private void CreateFile()
        {
            if (!Directory.Exists(_path))
                Directory.CreateDirectory(_path);

            if (!File.Exists(_fullpath))
                File.Create(_fullpath).Close();
        }
        #endregion

        public async Task SaveParametersAsync(SerialParametersModel model)
        {
            try
            {
                CreateFile();

                Model = model;

                var content = JsonConvert.SerializeObject(model);

                await File.WriteAllTextAsync(_fullpath, content);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public async Task<SerialParametersModel> GetParametersAsync()
        {
            try
            {
                CreateFile();

                var content = await File.ReadAllTextAsync(_fullpath);

                var model = JsonConvert.DeserializeObject<SerialParametersModel>(content);

                Model = model;

                return model;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                return default;
            }
        }
    }
}

using FilamentManufacturer.Domain.Enum.Serial;
using FilamentManufacturer.Domain.Models.Serial;
using FilamentManufacturer.Service.Extensions.SerialExtension;
using Newtonsoft.Json;
using System.IO.Ports;

namespace FilamentManufacturer.Service.Services.Serial
{
    public class SerialService : ISerialService
    {
        private SerialPort _port;

        private readonly int _baudrate;

        public event EventHandler ConnectedHandler;

        public SerialService()
        {
            _port = null;
            _baudrate = 9600;
        }

        public async Task ConnectSerialPortAsync()
        {
            await Task.Run(async () =>
            {
                while (true)
                {
                    string[] ports = SerialPort.GetPortNames();

                    if (_port != null)
                        continue;

                    foreach (string port in ports)
                    {
                        try
                        {
                            _port = new SerialPort(port, _baudrate, Parity.None, 8, StopBits.One);

                            _port.Open();
                            _port.ReadTimeout = 3000;
                            _port.WriteLine(SerialCommandExtension.SerialCommandFormat(SerialCommandEnum.Identify));

                            string response = _port.ReadLine();

                            if (response.Contains("3dpetfm_identified"))
                            {
                                //_port = serial;
                                _port.WriteLine(SerialCommandExtension.SerialCommandFormat(SerialCommandEnum.EnableInfos));

                                ConnectedHandler?.Invoke(this, new EventArgs());

                                break;
                                //return;
                            }
                            else
                            {
                                _port.Close();
                                _port = null;
                            }

                            //using (SerialPort serial = new SerialPort(port, _baudrate, Parity.None, 8, StopBits.One))
                            //{
                            //    serial.Open();
                            //    serial.ReadTimeout = 3000;
                            //    serial.WriteLine(SerialCommandExtension.SerialCommandFormat(SerialCommandEnum.Identify));

                            //    string response = serial.ReadLine();

                            //    if (response.Contains("3dpetfm_identified"))
                            //    {
                            //        _port = serial;
                            //        _port.WriteLine(SerialCommandExtension.SerialCommandFormat(SerialCommandEnum.EnableInfos));

                            //        ConnectedHandler?.Invoke(this, new EventArgs());

                            //        //return;
                            //    }
                            //}
                        }
                        catch (TimeoutException ex)
                        {
                            _port.Close();
                            _port = null;
                            continue;
                        }
                    }
                }
            });
        }

        public async Task<string> SendCommandSerialPortAsync(SerialCommandEnum command)
        {
            return await Task.Run(() =>
            {
                try
                {
                    if (_port == null)
                        return "Serial Port not found.";

                    _port.ReadTimeout = 5000;
                    _port.WriteLine(SerialCommandExtension.SerialCommandFormat(command));

                    //using (_port)
                    //{
                    //    _port.Open();
                    //    _port.ReadTimeout = 5000;
                    //    _port.WriteLine(SerialCommandExtension.SerialCommandFormat(command));
                    //}

                    return string.Empty;
                }
                catch (Exception ex)
                {
                    return $"Error!\nMessage: {ex.Message}\nStackTrace: {ex.StackTrace}";
                }
            });
        }

        public async Task<string> ReadInfosAsync()
        {
            var content = _port.ReadLine();

            return content;
        }
    }
}

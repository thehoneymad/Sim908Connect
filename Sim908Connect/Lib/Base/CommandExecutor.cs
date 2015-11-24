using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sim908Connect.Lib.Base
{
    public class CommandExecutor
    {
        SerialPort _serialPort;
        public CommandExecutor(SerialPort port)
        {
            _serialPort = port;
        }

        public string Execute(string Command, int timeout = 500)
        {
            _serialPort.Write(Command + "\r\n");
            Thread.Sleep(timeout);
            var stream = _serialPort.ReadExisting();
            ClearSerialBuffer();

            return stream;
        }

        private void ClearSerialBuffer()
        {
            _serialPort.DiscardInBuffer();
            _serialPort.DiscardOutBuffer();
        }

        public string Execute(string[] Commands, int[] timeouts)
        {

            string stream = string.Empty;
            if (Commands.Length != timeouts.Length)
                throw new ArgumentException("Command and timeout length is different");

            if (!(_serialPort.IsOpen))
                throw new InvalidOperationException("Serial Port is not opened yet");

            int count = 0;
            foreach (var command in Commands)
            {
                _serialPort.WriteLine(command);
                Thread.Sleep(timeouts[count]);
                stream = _serialPort.ReadExisting();
                count++;
            }
            ClearSerialBuffer();
            return stream;

        }

    }
}

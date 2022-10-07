# ocpp-sharp

An implementation of the Open Charge Point Protocol (OCPP).

Supported Versions:
- Ocpp 1.6
- Ocpp 2.0.1

## Dependencies
- Newtonsoft.Json

## Features
- C# Classes for every aspect of the OCPP Protocol.
- Easy to set up server and event system for processing messages

## Example
```C#
using System;
using OcppSharp;
using OcppSharp.Server;
using OcppSharp.Protocol.Version16.RequestPayloads;
using OcppSharp.Protocol.Version16.ResponsePayloads;

namespace OcppApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // set up a server to listen on port 80
            // Stations will be connecting to ws://<Hostname>/ocpp16/<Station ID>
            OcppSharpServer server = new OcppSharpServer("/ocpp16", ProtocolVersion.OCPP16, 80);
            server.Log = null; // Disable console logging
            server.RegisterHandler<BootNotificationRequest>((server, sender, req) => {

                Console.WriteLine($"Received BootNotification! (Message ID = {req.FullRequest!.MessageId})");
                Console.WriteLine($"Vendor: {req.chargePointVendor}");
                Console.WriteLine($"Serial Number: {req.chargePointSerialNumber}");
                // ...

                // Always need to send a response
                return new BootNotificationResponse()
                {
                    currentTime = DateTime.Now,
                    interval = 90 // Heartbeat Interval
                };
            });

            server.Start();
            Console.WriteLine("Server started!");
            Console.ReadLine();
            server.Stop();
        }
    }
}
```
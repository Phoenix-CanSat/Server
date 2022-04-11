using System;
using System.IO.Ports;
using System.Threading;
using System.Management;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Rest;
using RestSharp;

public static class Serial
{
    private static SerialPort? port;
    public static void Main()
    {
        using (var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE Caption like '%(COM%'"))
        {
            var portnames = SerialPort.GetPortNames();
            var ports = searcher.Get().Cast<ManagementBaseObject>().ToList().Select(p => p["Caption"].ToString());

            var portList = portnames.Select(n => n + " - " + ports.FirstOrDefault(s => s.Contains(n))).ToList();

            foreach (string s in portList)
            {
                Console.WriteLine(s);
            }
            int index = Convert.ToInt32(Console.ReadLine());
            port = new SerialPort("COM4", 115200, Parity.None, 8, StopBits.One);
            port.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
            port.Open();
            while(true);
        }
    }
    private static void SendData(string? resource,string identifier)
    {
        var client = new RestSharp.RestClient("api/" + identifier);
        var request = new RestRequest(resource, Method.Post);
        request.AddHeader(identifier, "application/json");
        var body = @"api/" + identifier;
        request.AddParameter("application/json", body, ParameterType.RequestBody);
        var response = client.GetAsync(request);
        Console.WriteLine(response.Result);
    }
    private static void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
    {
        // Show all the incoming data in the port's buffer
        string? data = port?.ReadExisting();
        if(data != null)
        {
            string[] databits = data.Split(',');
            SendData(databits[2], "temperature");
            SendData(databits[3], "pressure");
            SendData(databits[4] + "," + databits[5], "position");
            SendData(databits[6], "altitude");
            SendData(databits[7], "humidity");
            SendData(databits[9], "ground_temperature");
            SendData(databits[10], "ground_pressure");
        }
    }
}
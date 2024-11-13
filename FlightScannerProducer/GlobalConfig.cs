using FlightScannerProducer.ObjectRepository;
using System;
using System.Collections.Generic;
using System.Data;
using UiPath.Core;
using UiPath.Core.Activities.Storage;
using UiPath.Excel;
using UiPath.Excel.Activities;
using UiPath.Excel.Activities.API;
using UiPath.Excel.Activities.API.Models;
using UiPath.Orchestrator.Client.Models;
using UiPath.Testing;
using UiPath.Testing.Activities.TestData;
using UiPath.Testing.Activities.TestDataQueues.Enums;
using UiPath.Testing.Enums;
using UiPath.UIAutomationNext.API.Contracts;
using UiPath.UIAutomationNext.API.Models;
using UiPath.UIAutomationNext.Enums;

namespace FlightScannerProducer
{
    public class GlobalConfig
    {
         public static Dictionary<string, string> airportsMap = new Dictionary<string, string>
        {
            { "New York", "JFK" },
            { "Los Angeles", "LAX" },
            { "Chicago", "ORD" },
            { "San Francisco", "SFO" },
            { "Miami", "MIA" },
            { "Cluj-Napoca", "CLJ"},
            { "Malmo", "MMX"}
        };
        public static Dictionary<string, string> monthMap = new Dictionary<string, string>
        {
            { "January", "1" },
            { "February", "2" },
            { "March", "3" },
            { "April", "4" },
            { "May", "5" },
            { "June", "6" },
            { "July", "7" },
            { "August", "8" },
            { "September", "9" },
            { "October", "10" },
            { "November", "11" },
            { "December", "12" }
        };

    }
}
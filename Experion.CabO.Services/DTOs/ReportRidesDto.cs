﻿using System;

namespace Experion.CabO.Services.DTOs
{
    public class ReportRidesDto
    {
        public string From { get; set; }
        public string To { get; set; }
        public string RequestedBy { get; set; }
        public DateTime DateT { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Cab { get; set; }
        public string Driver { get; set; }
        public string ProjectCode { get; set; }
        public string Purpose { get; set; }
        public string Status { get; set; }
        public long? Kilometer { get; set; }
    }
}

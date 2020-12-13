﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RabbitMQPublisher.Models
{
    public class Document
    {
        public DateTime Date { get; set; }
        public string Name  { get; set; }
        public string Type { get; set; }
        public string Url { get; set; }
    }
}

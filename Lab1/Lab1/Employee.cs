﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Lab1
{
    [XmlRoot("New Employees", Namespace = "www.nerdinc.ninja")]
    public class Employee
    {
        [XmlAttribute("Employee ID")]
        public int ID { get; set; }
        [XmlElement("Full Name")]
        public string Name { get; set; }
        [XmlElement("Social Security Number")]
        public double SSNumber { get; set; }
        [XmlElement("Today's Date")]
        public DateTime EntryDate { get; set; }
        [XmlIgnore]
        public string JobRole { get; set; }
        
    }
}

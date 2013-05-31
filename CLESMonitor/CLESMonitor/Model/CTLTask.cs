﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLESMonitor.Model;

namespace CLESMonitor.Model
{
    public class CTLTask
    {
        private string identifier;
        private string type;

        private string eventIdentifier;
        public int lipValue { get; set; } //level of information processing
        public double moValue { get; set; } //mental occupancy
        public InformationDomain[] informationDomains { get; set; } //an array of enum representations of domains
        public double duration { get; set; } //in seconds
        public TimeSpan startTime { get; set; }
        public TimeSpan endTime { get; set; }
        public string description { get; set; }
        public bool isStopped { get; set; }

        /// <summary>
        /// Constructor method
        /// </summary>
        /// <param name="_type"></param>
        public CTLTask(string _identifier, string _type)
        {
            identifier = _identifier;
            type = _type;
            isStopped = false;
        }

        public string getIdentifier()
        {
            return this.identifier;
        }

        public string getType()
        {
            return this.type;
        }

        /// <summary>
        /// ToString method
        /// </summary>
        /// <returns>A string-representation of the CTLTask object</returns>
        public override string ToString()
        {
            return String.Format("Task: Identifier = {0}, Type = {1}, startTime = {2}, endTime = {3}", identifier, type, startTime.TotalSeconds, endTime.TotalSeconds);
        }
    }
}

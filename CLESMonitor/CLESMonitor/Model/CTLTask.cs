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
        public double moValue; //mental occupancy
        public int lipValue; //level of information processing
        public InformationDomain[] domains; //een array van enum representaties van domeinen
        public double duration; //in seconden
        public DateTime startTime;
        public DateTime endTime;
        public string description;

        private string name;

        /// <summary>
        /// Constructor methode
        /// </summary>
        /// <param name="_name"></param>
        public CTLTask(string _name)
        {
            name = _name;
        }

       

        /// <summary>
        /// ToString methode
        /// </summary>
        /// <returns>Een string-representatie van het CTLTask object</returns>
        public string toString()
        {
            return String.Format("Name = {0}", name);
        }

        public int getLip()
        {
            return this.lipValue;
        }

        public double getMO()
        {
            return this.moValue;
        }
        public InformationDomain[] getInfoDomain()
        {
            return this.domains;
        }
        public double getDuration()
        {
            return this.duration;
        }

        public void setDuration(double d)
        {
            this.duration = d;
        }
        public void setInformationDomain(InformationDomain[] dom)
        {
            this.domains = dom;
        }
        public void setMO(double m)
        {
            this.moValue = m;
        }
        public void setLip(int lip)
        {
            this.lipValue = lip;
        }
        public void setStartTime(DateTime time)
        {
            this.startTime = time;
        }
        public void setEndTime(DateTime time)
        {
            this.endTime = time;
        }

    }
}

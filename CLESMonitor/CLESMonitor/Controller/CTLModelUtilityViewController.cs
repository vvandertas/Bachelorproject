﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using CLESMonitor.Model.CL;
using CLESMonitor.View;

namespace CLESMonitor.Controller
{
    public class CTLModelUtilityViewController
    {
        /// <summary>The view this viewcontroller manages</summary>
        public CTLModelUtilityView View { get; private set; }
        /// <summary>The CTLModel that this utility-viewcontroller interacts with</summary>
        private CTLModel ctlModel;

        private XMLParser parser;

        /// <summary>
        /// The constructor method.
        /// </summary>
        /// <param name="ctlModel">A instance of the CTLModel class</param>
        public CTLModelUtilityViewController(CTLModel ctlModel, XMLParser parser)
        {
            this.View = new CTLModelUtilityView(this);
            this.ctlModel = ctlModel;
            this.parser = parser;
        }

        /// <summary>
        /// Action method when the openScenarioFileButton is clicked.
        /// </summary>
        public void openScenarioFileDialog()
        {
            if (View.openFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader streamReader = new StreamReader(File.Open(View.openFileDialog.FileName, FileMode.Open));
                parser.loadTextReader(streamReader);
                Console.WriteLine("Gekozen file: " + View.openFileDialog.FileName);
            }
        }
    }
}

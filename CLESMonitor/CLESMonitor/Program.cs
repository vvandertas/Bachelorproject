﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLESMonitor.Model.CL;
using CLESMonitor.Model.ES;
using CLESMonitor.Controller;

namespace CLESMonitor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            XMLParser parser = new XMLParser();
            PRLDomain prlDomain = new PRLDomain();
            CTLModel ctlModel = new CTLModel(parser, prlDomain);

            FuzzyModel fuzzyModel = new FuzzyModel();

            // Main viewcontroller setup
            var controller = new MainViewController(ctlModel,fuzzyModel);

            // Cognitive Load setup
            CTLModelUtilityVC ctlUtilityVC = new CTLModelUtilityVC(ctlModel, parser);
            controller.clUtilityView = ctlUtilityVC.View;

            // Emotional State setup
            FuzzyModelUtilityVC esUtilityVC = new FuzzyModelUtilityVC(fuzzyModel);
            controller.esUtilityView = esUtilityVC.View;

            Application.Run(controller.View);
        }
    }
}

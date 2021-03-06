﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLESMonitor.Model.CL
{
    /// <summary>
    /// This abstract class represents an Cognitive Load model.
    /// The method calculateModelValue() is the core method that will return
    /// calculated values from the model.
    /// </summary>
    public abstract class CLModel
    {
        /// <summary>The delegate for this object, implementing the CLModelDelegate interface</summary>
        public CLModelDelegate delegateObject;

        /// <summary>
        /// Starts a new session, calculateModelValue() will
        /// now produce valid values.
        /// </summary>
        public abstract void startSession();

        /// <summary>
        /// (Re)calculates the model value
        /// </summary>
        /// <returns>The model value</returns>
        public abstract double calculateModelValue();

        /// <summary>
        /// Stops the current session.
        /// </summary>
        public abstract void stopSession();
    }

    public interface CLModelDelegate
    {
        void displayLogMessage(string message);
    }
}

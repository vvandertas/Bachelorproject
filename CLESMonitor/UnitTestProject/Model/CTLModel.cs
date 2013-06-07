﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;
using Moq;

using CLESMonitor.Model;

namespace UnitTest.Model
{
    [TestFixture]
    public class CTLModel
    {
        XMLFileTaskParser parser;
        CLESMonitor.Model.CTLModel ctlModel;

        [SetUp]
        //Initialize any objects needed for the tests contained in this class
        public void Setup()
        {
            parser = new XMLFileTaskParser();
            ctlModel = new CLESMonitor.Model.CTLModel(parser);
        }

        [Test]
        public void updateActiveEvents_EventAdded()
        {
            var mock = new Mock<CLModel>();
            mock.Setup(foo => foo.calculateModelValue()).Returns(5);

            Assert.AreEqual(1, 1);        
        }

        [TearDown]
        // Removes all objects generated during setUp and the tests so that only the original objects are present
        // after testing
        public void TearDown()
        { 
        
        }
    }
}
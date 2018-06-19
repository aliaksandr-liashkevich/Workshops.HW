using System;
using HW.Tests.Mocks;
using HW.Tests.Stubs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HW.Tests
{
    [TestClass]
    public class LogAnalyzerTests
    {
        [TestMethod]
        public void IsValidLogFileName_Stub()
        {
            // arrange
            LogAnalyzer logAnalyzer = new LogAnalyzer(new ExtensionManagerStub());
            bool expected = true;

            // act
            bool actual = logAnalyzer.IsValidLogFileName("Hi!");

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsValidLogFileName_Mock()
        {
            // arrange
            ExtensionManagerMock mock = new ExtensionManagerMock();
            mock.Setup(() => true);
            LogAnalyzer logAnalyzer = new LogAnalyzer(mock);
            bool expected = true;
            
            // act
            logAnalyzer.IsValidLogFileName("Hello");

            // assert
            Assert.AreEqual(expected, mock.IsValidWasCalled);
        }
    }
}

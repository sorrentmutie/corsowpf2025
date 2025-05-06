using DemoUnitTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestDemoViewModel
{
    [TestClass]
    public class PersonaViewModelUnitTests
    {
        [TestMethod]
        public void Nome_SetValore_DeveGenerarePropertyChanged()
        {
            // Arrange
            var viewModel = new PersonaViewModel();
            string propertyName = string.Empty;
            viewModel.PropertyChanged += (sender, e) => propertyName = e.PropertyName;

            // Act
            viewModel.Nome = "Mario";
            Assert.AreEqual(propertyName, "Nome");
        }

        [TestMethod]
        public void Nome_SetValore_DovrebbeSollevarePropertyChanged()
        {
            // Arrange
            var viewModel = new PersonaViewModel();
            bool eventRaised = false;
            viewModel.PropertyChanged += (sender, e) =>
            {
                if (e.PropertyName == nameof(viewModel.Nome))
                {
                    eventRaised = true;
                }
            };
            viewModel.Nome = "Mario";
            Assert.IsTrue(eventRaised);
        }


    }
}

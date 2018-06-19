using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW.Tests.Mocks
{
    class ExtensionManagerMock : IExtensionManager
    {
        public bool IsValidWasCalled { get; set; }

        private Func<bool> _isValid;

        public void Setup(Func<bool> func)
        {
            _isValid = func;
        }

        public bool IsValid(string fileleName)
        {
            IsValidWasCalled = true;

            return _isValid.Invoke();
        }
    }
}

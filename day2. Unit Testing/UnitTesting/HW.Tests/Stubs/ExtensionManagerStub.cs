using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW.Tests.Stubs
{
    class ExtensionManagerStub : IExtensionManager
    {
        public bool IsValid(string fileleName)
        {
            return fileleName?.Length > 0 
                ? true 
                : false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProGrid.Common {
    public interface IProcessListProvider {
        BasicProcessInfo[] CaptureProcessList();
    }
}

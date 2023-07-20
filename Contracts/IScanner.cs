using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Motorola.Snapi;
using Motorola.Snapi.Constants.Enums;
using Motorola.Snapi.EventArguments;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IScanner
    {
        string Scan();
    }
}

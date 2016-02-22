using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AffinedLibrary
{
    /// <summary>
    /// List of supported PIDs
    /// </summary>
    public enum PID
    {
        Speed = 0x0D,
        RPM = 0x0C,
        IntakeTemp = 0x0f,
        OilTemp = 0x5C,
        CoolentTemp = 0x05,
        EngineLoad = 0x04,
        AirFlowRate = 0x10
    }

    /// <summary>
    /// List of supported Modes
    /// </summary>
    public enum Mode
    {
        Unknown = 0x00,
        CurrentData = 0x01,
        FreezeFrameData = 0x02,
        DiagnosticTroubleCodes = 0x03,
        ClearTroubleCodes = 0x04
    }
}

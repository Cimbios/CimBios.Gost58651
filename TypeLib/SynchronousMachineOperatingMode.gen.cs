using CimBios.Core.CimModel.DatatypeLib;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Режим работы синхронной машины.
/// </summary>
[CimClass("http://iec.ch/TC57/CIM100#SynchronousMachineOperatingMode")]
public enum SynchronousMachineOperatingMode
{
    /// <summary>
    /// 
    /// </summary>
    condenser,

    /// <summary>
    /// 
    /// </summary>
    generator,

    /// <summary>
    /// 
    /// </summary>
    motor,
}
using CimBios.Core.CimModel.DatatypeLib;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Состояние готовности к работе.
/// </summary>
[CimClass("http://iec.ch/TC57/CIM100#InUseStateKind")]
public enum InUseStateKind
{
    /// <summary>
    /// 
    /// </summary>
    inUse,

    /// <summary>
    /// 
    /// </summary>
    readyForUse,

    /// <summary>
    /// 
    /// </summary>
    notReadyForUse,
}
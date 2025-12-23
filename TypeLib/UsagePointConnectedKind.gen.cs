using CimBios.Core.CimModel.DatatypeLib;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Состояние точки поставки по отношению к подключению к сети.
/// </summary>
[CimClass("http://iec.ch/TC57/CIM100#UsagePointConnectedKind")]
public enum UsagePointConnectedKind
{
    /// <summary>
    /// 
    /// </summary>
    connected,

    /// <summary>
    /// 
    /// </summary>
    logicallyDisconnected,

    /// <summary>
    /// 
    /// </summary>
    physicallyDisconnected,
}
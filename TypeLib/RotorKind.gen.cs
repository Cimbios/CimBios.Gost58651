using CimBios.Core.CimModel.DatatypeLib;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Тип ротора синхронной машины.
/// </summary>
[CimClass("http://iec.ch/TC57/CIM100#RotorKind")]
public enum RotorKind
{
    /// <summary>
    /// 
    /// </summary>
    roundRotor,

    /// <summary>
    /// 
    /// </summary>
    salientPole,
}
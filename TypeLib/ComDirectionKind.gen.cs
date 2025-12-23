using CimBios.Core.CimModel.DatatypeLib;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Вид направления коммуникации.
/// </summary>
[CimClass("http://iec.ch/TC57/CIM100#ComDirectionKind")]
public enum ComDirectionKind
{
    /// <summary>
    /// 
    /// </summary>
    biDirectional,

    /// <summary>
    /// 
    /// </summary>
    fromDevice,

    /// <summary>
    /// 
    /// </summary>
    toDevice,
}
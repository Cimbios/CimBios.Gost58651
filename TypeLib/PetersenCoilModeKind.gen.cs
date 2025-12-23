using CimBios.Core.CimModel.DatatypeLib;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Режим управления катушкой Петерсона илидугогасящим реактором.
/// </summary>
[CimClass("http://iec.ch/TC57/CIM100#PetersenCoilModeKind")]
public enum PetersenCoilModeKind
{
    /// <summary>
    /// 
    /// </summary>
    automaticPositioning,

    /// <summary>
    /// 
    /// </summary>
    @fixed,

    /// <summary>
    /// 
    /// </summary>
    manual,
}
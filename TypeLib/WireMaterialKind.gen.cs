using CimBios.Core.CimModel.DatatypeLib;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Тип материала проводников.
/// </summary>
[CimClass("http://iec.ch/TC57/CIM100#WireMaterialKind")]
public enum WireMaterialKind
{
    /// <summary>
    /// 
    /// </summary>
    copper,

    /// <summary>
    /// 
    /// </summary>
    steel,

    /// <summary>
    /// 
    /// </summary>
    aluminum,

    /// <summary>
    /// 
    /// </summary>
    aluminumSteel,

    /// <summary>
    /// 
    /// </summary>
    acsr,

    /// <summary>
    /// 
    /// </summary>
    aluminumAlloy,

    /// <summary>
    /// 
    /// </summary>
    aluminumAlloySteel,

    /// <summary>
    /// 
    /// </summary>
    aaac,

    /// <summary>
    /// 
    /// </summary>
    other,
}
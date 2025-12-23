using CimBios.Core.CimModel.DatatypeLib;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Материал экрана кабеля.
/// </summary>
[CimClass("http://iec.ch/TC57/CIM100#CableShieldMaterialKind")]
public enum CableShieldMaterialKind
{
    /// <summary>
    /// 
    /// </summary>
    lead,

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
    other,
}
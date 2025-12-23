using CimBios.Core.CimModel.DatatypeLib;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Тип сооружения.
/// </summary>
[CimClass("http://iec.ch/TC57/CIM100#FacilityKind")]
public enum FacilityKind
{
    /// <summary>
    /// 
    /// </summary>
    substationHydroPlant,

    /// <summary>
    /// 
    /// </summary>
    substationFossilPlant,

    /// <summary>
    /// 
    /// </summary>
    substationNuclearPlant,

    /// <summary>
    /// 
    /// </summary>
    substationTransmission,

    /// <summary>
    /// 
    /// </summary>
    substationDistribution,

    /// <summary>
    /// 
    /// </summary>
    substationWindPlant,

    /// <summary>
    /// 
    /// </summary>
    substationSolarPlant,
}
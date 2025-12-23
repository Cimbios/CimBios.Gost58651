using CimBios.Core.CimModel.DatatypeLib;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Режимы работы, в которых гидроагрегат способен работать.
/// </summary>
[CimClass("http://iec.ch/TC57/CIM100#HydroEnergyConversionKind")]
public enum HydroEnergyConversionKind
{
    /// <summary>
    /// 
    /// </summary>
    generator,

    /// <summary>
    /// 
    /// </summary>
    pumpAndGenerator,
}
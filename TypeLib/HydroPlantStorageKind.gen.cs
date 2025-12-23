using CimBios.Core.CimModel.DatatypeLib;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Тип водохранилища.
/// </summary>
[CimClass("http://iec.ch/TC57/CIM100#HydroPlantStorageKind")]
public enum HydroPlantStorageKind
{
    /// <summary>
    /// 
    /// </summary>
    pumpedStorage,

    /// <summary>
    /// 
    /// </summary>
    runOfRiver,

    /// <summary>
    /// 
    /// </summary>
    storage,
}
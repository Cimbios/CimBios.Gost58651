using CimBios.Core.CimModel.DatatypeLib;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Тип конструкции опоры ЛЭП.
/// </summary>
[CimClass("http://iec.ch/TC57/CIM100#TowerConstructionKind")]
public enum TowerConstructionKind
{
    /// <summary>
    /// 
    /// </summary>
    suspension,

    /// <summary>
    /// 
    /// </summary>
    tension,
}
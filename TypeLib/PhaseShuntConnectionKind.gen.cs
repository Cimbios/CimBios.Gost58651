using CimBios.Core.CimModel.DatatypeLib;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Конфигурация соединения фаз для оборудования и устройств, обладающих одним полюсом (например, нагрузка или батарея статических конденсаторов).
/// </summary>
[CimClass("http://iec.ch/TC57/CIM100#PhaseShuntConnectionKind")]
public enum PhaseShuntConnectionKind
{
    /// <summary>
    /// 
    /// </summary>
    D,

    /// <summary>
    /// 
    /// </summary>
    G,

    /// <summary>
    /// 
    /// </summary>
    I,

    /// <summary>
    /// 
    /// </summary>
    Y,

    /// <summary>
    /// 
    /// </summary>
    Yn,
}
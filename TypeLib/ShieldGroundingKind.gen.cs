using CimBios.Core.CimModel.DatatypeLib;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Тип заземления экрана.
/// </summary>
[CimClass("http://gost.ru/2019/schema-cim01#ShieldGroundingKind")]
public enum ShieldGroundingKind
{
    /// <summary>
    /// 
    /// </summary>
    none,

    /// <summary>
    /// 
    /// </summary>
    oneSide,

    /// <summary>
    /// 
    /// </summary>
    twoSide,
}
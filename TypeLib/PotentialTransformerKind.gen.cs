using CimBios.Core.CimModel.DatatypeLib;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Конструкция трансформатора напряжения.
/// </summary>
[CimClass("http://iec.ch/TC57/CIM100#PotentialTransformerKind")]
public enum PotentialTransformerKind
{
    /// <summary>
    /// 
    /// </summary>
    capacitiveCoupling,

    /// <summary>
    /// 
    /// </summary>
    inductive,
}
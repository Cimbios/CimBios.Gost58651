using CimBios.Core.CimModel.DatatypeLib;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Тип изоляции проводников.
/// </summary>
[CimClass("http://iec.ch/TC57/CIM100#WireInsulationKind")]
public enum WireInsulationKind
{
    /// <summary>
    /// 
    /// </summary>
    asbestosAndVarnishedCambric,

    /// <summary>
    /// 
    /// </summary>
    butyl,

    /// <summary>
    /// 
    /// </summary>
    ethylenePropyleneRubber,

    /// <summary>
    /// 
    /// </summary>
    highMolecularWeightPolyethylene,

    /// <summary>
    /// 
    /// </summary>
    treeResistantHighMolecularWeightPolyethylene,

    /// <summary>
    /// 
    /// </summary>
    oilPaper,

    /// <summary>
    /// 
    /// </summary>
    ozoneResistantRubber,

    /// <summary>
    /// 
    /// </summary>
    beltedPilc,

    /// <summary>
    /// 
    /// </summary>
    rubber,

    /// <summary>
    /// 
    /// </summary>
    siliconRubber,

    /// <summary>
    /// 
    /// </summary>
    varnishedCambricCloth,

    /// <summary>
    /// 
    /// </summary>
    varnishedDacronGlass,

    /// <summary>
    /// 
    /// </summary>
    crosslinkedPolyethylene,

    /// <summary>
    /// 
    /// </summary>
    treeRetardantCrosslinkedPolyethylene,

    /// <summary>
    /// 
    /// </summary>
    highPressureFluidFilled,

    /// <summary>
    /// 
    /// </summary>
    other,
}
using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.DatatypeLib.TypeLib;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Координатная точка в системе географических координат.
/// </summary>
[CimClass(ClassUri)]
public partial class PositionPoint(IOIDDescriptor oid, ICimMetaClass metaClass)
    : Resource(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#PositionPoint";

    /// <summary>
    /// Последовательный, начиная с нуля, номер группы.
    /// </summary>
    public int? groupNumber
    {
        get => GetAttribute<int?>(nameof(groupNumber));
        set => SetAttribute(nameof(groupNumber), value);
    }

    /// <summary>
    /// Последовательный, начиная с нуля, номер координаты в серии координат.
    /// </summary>
    public int? sequenceNumber
    {
        get => GetAttribute<int?>(nameof(sequenceNumber));
        set => SetAttribute(nameof(sequenceNumber), value);
    }

    /// <summary>
    /// Расположение по координате x.
    /// </summary>
    public string? xPosition
    {
        get => GetAttribute<string?>(nameof(xPosition));
        set => SetAttribute(nameof(xPosition), value);
    }

    /// <summary>
    /// Расположение по координате y.
    /// </summary>
    public string? yPosition
    {
        get => GetAttribute<string?>(nameof(yPosition));
        set => SetAttribute(nameof(yPosition), value);
    }

    /// <summary>
    /// Расположение по координате z.
    /// </summary>
    public string? zPosition
    {
        get => GetAttribute<string?>(nameof(zPosition));
        set => SetAttribute(nameof(zPosition), value);
    }

    /// <summary>
    /// Расположение объекта энергосистемы, соответствующее координатной точке.
    /// </summary>
    public Location? Location
    {
        get => GetAssoc1To1<Location>(nameof(Location));
        set => SetAssoc1To1(nameof(Location), value);
    }
}
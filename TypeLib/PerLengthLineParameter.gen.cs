using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Базовый класс для удельных параметров участка ЛЭП.
/// </summary>
[CimClass(ClassUri)]
public partial class PerLengthLineParameter(IOIDDescriptor oid, ICimMetaClass metaClass)
    : IdentifiedObject(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#PerLengthLineParameter";


    /// <summary>
    /// Технические параметры проводников многофазного кабеля/ЛЭП, к которому относятся указанные удельные параметры.
    /// </summary>
    public WireAssemblyInfo? WireAssemblyInfo
    {
        get => GetAssoc1To1<WireAssemblyInfo>(nameof(WireAssemblyInfo));
        set => SetAssoc1To1(nameof(WireAssemblyInfo), value);
    }
}
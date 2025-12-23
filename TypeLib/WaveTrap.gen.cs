using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// ВЧ заградитель.
/// </summary>
[CimClass(ClassUri)]
public partial class WaveTrap(IOIDDescriptor oid, ICimMetaClass metaClass)
    : AuxiliaryEquipment(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#WaveTrap";

    /// <summary>
    /// Номинальный ток высокочастотного заградителя, А.
    /// </summary>
    public float? ratedCurrent
    {
        get => GetAttribute<float?>(nameof(ratedCurrent));
        set => SetAttribute(nameof(ratedCurrent), value);
    }
}
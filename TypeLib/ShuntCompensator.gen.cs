using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Шунтирующее компенсирующее устройство.
/// </summary>
[CimClass(ClassUri)]
public partial class ShuntCompensator(IOIDDescriptor oid, ICimMetaClass metaClass)
    : RegulatingCondEq(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#ShuntCompensator";

    /// <summary>
    /// Если присвоено значение &#171;Истина&#187;, нейтраль глухо заземлена.
    /// </summary>
    public bool? grounded
    {
        get => GetAttribute<bool?>(nameof(grounded));
        set => SetAttribute(nameof(grounded), value);
    }

    /// <summary>
    /// Максимальное количество секций, которое может быть включено.
    /// </summary>
    public int? maximumSections
    {
        get => GetAttribute<int?>(nameof(maximumSections));
        set => SetAttribute(nameof(maximumSections), value);
    }

    /// <summary>
    /// Номинальное напряжение, кВ.
    /// </summary>
    public float? nomU
    {
        get => GetAttribute<float?>(nameof(nomU));
        set => SetAttribute(nameof(nomU), value);
    }

    /// <summary>
    /// Тип соединения обмоток.
    /// </summary>
    public PhaseShuntConnectionKind? phaseConnection
    {
        get => GetAttribute<PhaseShuntConnectionKind?>(nameof(phaseConnection));
        set => SetAttribute(nameof(phaseConnection), value);
    }
}
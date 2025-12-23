using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Коммуникационная функция коммуникационного оборудования или устройства, такого как прибор учета.
/// </summary>
[CimClass(ClassUri)]
public partial class ComFunction(IOIDDescriptor oid, ICimMetaClass metaClass)
    : EndDeviceFunction(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#ComFunction";

    /// <summary>
    /// Идентификационный номер связи (например, серийный номер, IP-адрес, номер телефона и т. д.)
    /// </summary>
    public string? amrAddress
    {
        get => GetAttribute<string?>(nameof(amrAddress));
        set => SetAttribute(nameof(amrAddress), value);
    }

    /// <summary>
    /// Идентификационный номер связи (например, номер порта, серийный номер, идентификатор сборщика данных и т. д.) УСПД.
    /// </summary>
    public string? amrRouter
    {
        get => GetAttribute<string?>(nameof(amrRouter));
        set => SetAttribute(nameof(amrRouter), value);
    }

    /// <summary>
    /// Вид направления коммуникации.
    /// </summary>
    public ComDirectionKind? direction
    {
        get => GetAttribute<ComDirectionKind?>(nameof(direction));
        set => SetAttribute(nameof(direction), value);
    }

    /// <summary>
    /// Вид технологии коммуникации.
    /// </summary>
    public ComTechnologyKind? technology
    {
        get => GetAttribute<ComTechnologyKind?>(nameof(technology));
        set => SetAttribute(nameof(technology), value);
    }
}
using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Набор эксплуатационных ограничений/пределов.
/// </summary>
[CimClass(ClassUri)]
public partial class OperationalLimitSet(IOIDDescriptor oid, ICimMetaClass metaClass)
    : IdentifiedObject(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#OperationalLimitSet";


    /// <summary>
    /// Полюс, к которому относится набор эксплуатационных ограничений/пределов.
    /// </summary>
    public ACDCTerminal? Terminal
    {
        get => GetAssoc1To1<ACDCTerminal>(nameof(Terminal));
        set => SetAssoc1To1(nameof(Terminal), value);
    }

    /// <summary>
    /// Оборудование, к которому относится набор эксплуатационных ограничений/пределов.
    /// </summary>
    public Equipment? Equipment
    {
        get => GetAssoc1To1<Equipment>(nameof(Equipment));
        set => SetAssoc1To1(nameof(Equipment), value);
    }

    /// <summary>
    /// Эксплуатационные ограничения/пределы.
    /// </summary>
    public OperationalLimit[] OperationalLimitValue => GetAssoc1ToM<OperationalLimit>(nameof(OperationalLimitValue));

    public void AddToOperationalLimitValue(OperationalLimit assocObject) =>
        AddAssoc1ToM(nameof(OperationalLimitValue), assocObject);

    public void RemoveFromOperationalLimitValue(OperationalLimit assocObject) =>
        RemoveAssoc1ToM(nameof(OperationalLimitValue), assocObject);

    public void RemoveAllFromOperationalLimitValue() => RemoveAllAssocs1ToM(nameof(OperationalLimitValue));
}
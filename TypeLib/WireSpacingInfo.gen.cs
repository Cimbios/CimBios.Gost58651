using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Конструктивные фазные параметры проводника.
/// </summary>
[CimClass(ClassUri)]
public partial class WireSpacingInfo(IOIDDescriptor oid, ICimMetaClass metaClass)
    : AssetInfo(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#WireSpacingInfo";

    /// <summary>
    /// Проводник является кабелем (если присвоено значение &#171;Истина&#187;).
    /// </summary>
    public bool? isCable
    {
        get => GetAttribute<bool?>(nameof(isCable));
        set => SetAttribute(nameof(isCable), value);
    }

    /// <summary>
    /// Количество проводников в симметричном пучке.
    /// </summary>
    public int? phaseWireCount
    {
        get => GetAttribute<int?>(nameof(phaseWireCount));
        set => SetAttribute(nameof(phaseWireCount), value);
    }

    /// <summary>
    /// Расстояние между проводниками в симметричном пучке, м.
    /// </summary>
    public float? phaseWireSpacing
    {
        get => GetAttribute<float?>(nameof(phaseWireSpacing));
        set => SetAttribute(nameof(phaseWireSpacing), value);
    }


    /// <summary>
    /// Положение одиночных проводов (фазных или нейтральных).
    /// </summary>
    public WirePosition[] WirePositions => GetAssoc1ToM<WirePosition>(nameof(WirePositions));

    public void AddToWirePositions(WirePosition assocObject) => AddAssoc1ToM(nameof(WirePositions), assocObject);

    public void RemoveFromWirePositions(WirePosition assocObject) =>
        RemoveAssoc1ToM(nameof(WirePositions), assocObject);

    public void RemoveAllFromWirePositions() => RemoveAllAssocs1ToM(nameof(WirePositions));

    /// <summary>
    /// Конструктивные элементы линии переменного тока, к которым относится информация о расщепления проводников.
    /// </summary>
    public Structure[] Structures => GetAssoc1ToM<Structure>(nameof(Structures));

    public void AddToStructures(Structure assocObject) => AddAssoc1ToM(nameof(Structures), assocObject);
    public void RemoveFromStructures(Structure assocObject) => RemoveAssoc1ToM(nameof(Structures), assocObject);
    public void RemoveAllFromStructures() => RemoveAllAssocs1ToM(nameof(Structures));
}
using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Полюс электропроводящего оборудования.
/// </summary>
[CimClass(ClassUri)]
public partial class Terminal(IOIDDescriptor oid, ICimMetaClass metaClass)
    : ACDCTerminal(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#Terminal";

    /// <summary>
    /// Код фазы терминала.
    /// </summary>
    public PhaseCode? phases
    {
        get => GetAttribute<PhaseCode?>(nameof(phases));
        set => SetAttribute(nameof(phases), value);
    }

    /// <summary>
    /// Электропроводящее оборудование, к которому принадлежит полюс.
    /// </summary>
    public ConductingEquipment? ConductingEquipment
    {
        get => GetAssoc1To1<ConductingEquipment>(nameof(ConductingEquipment));
        set => SetAssoc1To1(nameof(ConductingEquipment), value);
    }

    /// <summary>
    /// Соединительный узел полюсов.
    /// </summary>
    public ConnectivityNode? ConnectivityNode
    {
        get => GetAssoc1To1<ConnectivityNode>(nameof(ConnectivityNode));
        set => SetAssoc1To1(nameof(ConnectivityNode), value);
    }

    /// <summary>
    /// Полюс оборудования, ассоциированный с системой автоматического регулирования.
    /// </summary>
    public RegulatingControl[] RegulatingControl => GetAssoc1ToM<RegulatingControl>(nameof(RegulatingControl));

    public void AddToRegulatingControl(RegulatingControl assocObject) =>
        AddAssoc1ToM(nameof(RegulatingControl), assocObject);

    public void RemoveFromRegulatingControl(RegulatingControl assocObject) =>
        RemoveAssoc1ToM(nameof(RegulatingControl), assocObject);

    public void RemoveAllFromRegulatingControl() => RemoveAllAssocs1ToM(nameof(RegulatingControl));

    /// <summary>
    /// Выводы трансформатора, к которым подключен полюс относится переключатель регулировочных ответвлений с продольным регулированием.
    /// </summary>
    public TransformerEnd[] TransformerEnd => GetAssoc1ToM<TransformerEnd>(nameof(TransformerEnd));

    public void AddToTransformerEnd(TransformerEnd assocObject) => AddAssoc1ToM(nameof(TransformerEnd), assocObject);

    public void RemoveFromTransformerEnd(TransformerEnd assocObject) =>
        RemoveAssoc1ToM(nameof(TransformerEnd), assocObject);

    public void RemoveAllFromTransformerEnd() => RemoveAllAssocs1ToM(nameof(TransformerEnd));

    /// <summary>
    /// Электромагнитные связи с участками линии переменного тока, каждый из которых объявлен первым в паре взаимосвязанных.
    /// </summary>
    public MutualCoupling[] HasFirstMutualCoupling => GetAssoc1ToM<MutualCoupling>(nameof(HasFirstMutualCoupling));

    public void AddToHasFirstMutualCoupling(MutualCoupling assocObject) =>
        AddAssoc1ToM(nameof(HasFirstMutualCoupling), assocObject);

    public void RemoveFromHasFirstMutualCoupling(MutualCoupling assocObject) =>
        RemoveAssoc1ToM(nameof(HasFirstMutualCoupling), assocObject);

    public void RemoveAllFromHasFirstMutualCoupling() => RemoveAllAssocs1ToM(nameof(HasFirstMutualCoupling));

    /// <summary>
    /// Вспомогательное оборудование, подключенное к полюсу электропроводящего оборудования.
    /// </summary>
    public AuxiliaryEquipment[] AuxiliaryEquipment => GetAssoc1ToM<AuxiliaryEquipment>(nameof(AuxiliaryEquipment));

    public void AddToAuxiliaryEquipment(AuxiliaryEquipment assocObject) =>
        AddAssoc1ToM(nameof(AuxiliaryEquipment), assocObject);

    public void RemoveFromAuxiliaryEquipment(AuxiliaryEquipment assocObject) =>
        RemoveAssoc1ToM(nameof(AuxiliaryEquipment), assocObject);

    public void RemoveAllFromAuxiliaryEquipment() => RemoveAllAssocs1ToM(nameof(AuxiliaryEquipment));

    /// <summary>
    /// Электромагнитные связи с участками линии переменного тока, каждый из которых объявлен вторым в паре взаимосвязанных.
    /// </summary>
    public MutualCoupling[] HasSecondMutualCoupling => GetAssoc1ToM<MutualCoupling>(nameof(HasSecondMutualCoupling));

    public void AddToHasSecondMutualCoupling(MutualCoupling assocObject) =>
        AddAssoc1ToM(nameof(HasSecondMutualCoupling), assocObject);

    public void RemoveFromHasSecondMutualCoupling(MutualCoupling assocObject) =>
        RemoveAssoc1ToM(nameof(HasSecondMutualCoupling), assocObject);

    public void RemoveAllFromHasSecondMutualCoupling() => RemoveAllAssocs1ToM(nameof(HasSecondMutualCoupling));

    /// <summary>
    /// Сегменты участка линии переменного тока, нумеруемые относительно полюса.
    /// </summary>
    public ACLineSeriesSection[] ACLineSeriesSection => GetAssoc1ToM<ACLineSeriesSection>(nameof(ACLineSeriesSection));

    public void AddToACLineSeriesSection(ACLineSeriesSection assocObject) =>
        AddAssoc1ToM(nameof(ACLineSeriesSection), assocObject);

    public void RemoveFromACLineSeriesSection(ACLineSeriesSection assocObject) =>
        RemoveAssoc1ToM(nameof(ACLineSeriesSection), assocObject);

    public void RemoveAllFromACLineSeriesSection() => RemoveAllAssocs1ToM(nameof(ACLineSeriesSection));
}
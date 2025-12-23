using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Электрический вывод трансформатора.
/// </summary>
[CimClass(ClassUri)]
public partial class TransformerEnd(IOIDDescriptor oid, ICimMetaClass metaClass)
    : IdentifiedObject(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#TransformerEnd";

    /// <summary>
    /// Номер вывода трансформатора.
    /// </summary>
    public int? endNumber
    {
        get => GetAttribute<int?>(nameof(endNumber));
        set => SetAttribute(nameof(endNumber), value);
    }

    /// <summary>
    /// Нейтраль глухо заземлена (если присвоено значение &#171;Истина&#187;).
    /// </summary>
    public bool? grounded
    {
        get => GetAttribute<bool?>(nameof(grounded));
        set => SetAttribute(nameof(grounded), value);
    }

    /// <summary>
    /// Активное сопротивление заземления нейтрали, Ом.
    /// </summary>
    public float? rground
    {
        get => GetAttribute<float?>(nameof(rground));
        set => SetAttribute(nameof(rground), value);
    }

    /// <summary>
    /// Реактивное сопротивление заземления нейтрали, Ом.
    /// </summary>
    public float? xground
    {
        get => GetAttribute<float?>(nameof(xground));
        set => SetAttribute(nameof(xground), value);
    }

    /// <summary>
    /// Фазосдвигающий переключатель регулировочных ответвлений обмотки трансформатора.
    /// </summary>
    public PhaseTapChanger? PhaseTapChanger
    {
        get => GetAssoc1To1<PhaseTapChanger>(nameof(PhaseTapChanger));
        set => SetAssoc1To1(nameof(PhaseTapChanger), value);
    }

    /// <summary>
    /// Переключатель регулировочных ответвлений трансформатора.
    /// </summary>
    public RatioTapChanger? RatioTapChanger
    {
        get => GetAssoc1To1<RatioTapChanger>(nameof(RatioTapChanger));
        set => SetAssoc1To1(nameof(RatioTapChanger), value);
    }

    /// <summary>
    /// Электрические параметры магнитопровода трансформатора связанные с выводом трансформатора.
    /// </summary>
    public TransformerCoreAdmittance? CoreAdmittance
    {
        get => GetAssoc1To1<TransformerCoreAdmittance>(nameof(CoreAdmittance));
        set => SetAssoc1To1(nameof(CoreAdmittance), value);
    }

    /// <summary>
    /// Электрические параметры трансформатора по модели звезда, связанные с выводом трансформатора.
    /// </summary>
    public TransformerStarImpedance? StarImpedance
    {
        get => GetAssoc1To1<TransformerStarImpedance>(nameof(StarImpedance));
        set => SetAssoc1To1(nameof(StarImpedance), value);
    }

    /// <summary>
    /// Стандартное номинальное напряжение вывода трансформатора.
    /// </summary>
    public BaseVoltage? BaseVoltage
    {
        get => GetAssoc1To1<BaseVoltage>(nameof(BaseVoltage));
        set => SetAssoc1To1(nameof(BaseVoltage), value);
    }

    /// <summary>
    /// Полюс силового трансформатора, к которому подключены его выводы.
    /// </summary>
    public Terminal? Terminal
    {
        get => GetAssoc1To1<Terminal>(nameof(Terminal));
        set => SetAssoc1To1(nameof(Terminal), value);
    }

    /// <summary>
    /// Все взаимные сопротивления между текущимвыводом �из� и другими выводами �в�.
    /// </summary>
    public TransformerMeshImpedance[] ToMeshImpedance =>
        GetAssoc1ToM<TransformerMeshImpedance>(nameof(ToMeshImpedance));

    public void AddToToMeshImpedance(TransformerMeshImpedance assocObject) =>
        AddAssoc1ToM(nameof(ToMeshImpedance), assocObject);

    public void RemoveFromToMeshImpedance(TransformerMeshImpedance assocObject) =>
        RemoveAssoc1ToM(nameof(ToMeshImpedance), assocObject);

    public void RemoveAllFromToMeshImpedance() => RemoveAllAssocs1ToM(nameof(ToMeshImpedance));

    /// <summary>
    /// Все взаимные сопротивления между текущимвыводом �в� и другими выводами �из�.
    /// </summary>
    public TransformerMeshImpedance[] FromMeshImpedance =>
        GetAssoc1ToM<TransformerMeshImpedance>(nameof(FromMeshImpedance));

    public void AddToFromMeshImpedance(TransformerMeshImpedance assocObject) =>
        AddAssoc1ToM(nameof(FromMeshImpedance), assocObject);

    public void RemoveFromFromMeshImpedance(TransformerMeshImpedance assocObject) =>
        RemoveAssoc1ToM(nameof(FromMeshImpedance), assocObject);

    public void RemoveAllFromFromMeshImpedance() => RemoveAllAssocs1ToM(nameof(FromMeshImpedance));
}
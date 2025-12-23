using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Строка таблицы фазосдвигающего переключателя регулировочных ответвлений обмотки трансформатора.
/// </summary>
[CimClass(ClassUri)]
public partial class PhaseTapChangerTablePoint(IOIDDescriptor oid, ICimMetaClass metaClass)
    : TapChangerTablePoint(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#PhaseTapChangerTablePoint";

    /// <summary>
    /// Разница углов, град.
    /// </summary>
    public float? angle
    {
        get => GetAttribute<float?>(nameof(angle));
        set => SetAttribute(nameof(angle), value);
    }

    /// <summary>
    /// Таблица фазосдвигающего переключателя регулировочных ответвленийобмотки трансформатора, к которой относится строка таблицы.
    /// </summary>
    public PhaseTapChangerTable? PhaseTapChangerTable
    {
        get => GetAssoc1To1<PhaseTapChangerTable>(nameof(PhaseTapChangerTable));
        set => SetAssoc1To1(nameof(PhaseTapChangerTable), value);
    }
}
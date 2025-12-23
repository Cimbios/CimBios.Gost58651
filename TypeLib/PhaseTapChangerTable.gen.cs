using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Таблица фазосдвигающего переключателя регулировочных ответвлений обмотки трансформатора.
/// </summary>
[CimClass(ClassUri)]
public partial class PhaseTapChangerTable(IOIDDescriptor oid, ICimMetaClass metaClass)
    : IdentifiedObject(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#PhaseTapChangerTable";


    /// <summary>
    /// Фазосдвигающий переключатель регулировочных ответвлений обмоткитрансформатора с табличным представлением зависимости.
    /// </summary>
    public PhaseTapChangerTabular? PhaseTapChangerTabular
    {
        get => GetAssoc1To1<PhaseTapChangerTabular>(nameof(PhaseTapChangerTabular));
        set => SetAssoc1To1(nameof(PhaseTapChangerTabular), value);
    }

    /// <summary>
    /// Строки таблицы фазосдвигающего переключателя регулировочных ответвлений обмотки трансформатора.
    /// </summary>
    public PhaseTapChangerTablePoint[] PhaseTapChangerTablePoint =>
        GetAssoc1ToM<PhaseTapChangerTablePoint>(nameof(PhaseTapChangerTablePoint));

    public void AddToPhaseTapChangerTablePoint(PhaseTapChangerTablePoint assocObject) =>
        AddAssoc1ToM(nameof(PhaseTapChangerTablePoint), assocObject);

    public void RemoveFromPhaseTapChangerTablePoint(PhaseTapChangerTablePoint assocObject) =>
        RemoveAssoc1ToM(nameof(PhaseTapChangerTablePoint), assocObject);

    public void RemoveAllFromPhaseTapChangerTablePoint() => RemoveAllAssocs1ToM(nameof(PhaseTapChangerTablePoint));
}
using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Фазосдвигающий переключатель.
/// </summary>
[CimClass(ClassUri)]
public partial class PhaseTapChangerTabular(IOIDDescriptor oid, ICimMetaClass metaClass)
    : PhaseTapChanger(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#PhaseTapChangerTabular";


    /// <summary>
    /// Таблица фазосдвигающего переключателя регулировочных ответвлений обмотки трансформатора.
    /// </summary>
    public PhaseTapChangerTable? PhaseTapChangerTable
    {
        get => GetAssoc1To1<PhaseTapChangerTable>(nameof(PhaseTapChangerTable));
        set => SetAssoc1To1(nameof(PhaseTapChangerTable), value);
    }
}
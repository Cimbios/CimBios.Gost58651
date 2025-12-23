using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Фазосдвигающий переключатель регулировочных ответвлений обмотки трансформатора.
/// </summary>
[CimClass(ClassUri)]
public partial class PhaseTapChanger(IOIDDescriptor oid, ICimMetaClass metaClass)
    : TapChanger(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#PhaseTapChanger";


    /// <summary>
    /// Вывод силового трансформатора, к которому относится переключатель регулировочных ответвлений с поперечным регулированием.
    /// </summary>
    public TransformerEnd? TransformerEnd
    {
        get => GetAssoc1To1<TransformerEnd>(nameof(TransformerEnd));
        set => SetAssoc1To1(nameof(TransformerEnd), value);
    }
}
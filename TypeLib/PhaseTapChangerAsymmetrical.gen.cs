using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Фазовращатель ассиметричный.
/// </summary>
[CimClass(ClassUri)]
public partial class PhaseTapChangerAsymmetrical(IOIDDescriptor oid, ICimMetaClass metaClass)
    : PhaseTapChangerNonLinear(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#PhaseTapChangerAsymmetrical";

    /// <summary>
    /// Угол, на который вектор напряжения вольтодобавки опережает напряжение вывода, к которому присоединен переключатель, град.
    /// </summary>
    public float? windingConnectionAngle
    {
        get => GetAttribute<float?>(nameof(windingConnectionAngle));
        set => SetAttribute(nameof(windingConnectionAngle), value);
    }
}
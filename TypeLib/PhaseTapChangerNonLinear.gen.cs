using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Нелинейный фазосдвигающий переключатель регулировочных ответвлений обмотки трансформатора.
/// </summary>
[CimClass(ClassUri)]
public partial class PhaseTapChangerNonLinear(IOIDDescriptor oid, ICimMetaClass metaClass)
    : PhaseTapChanger(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#PhaseTapChangerNonLinear";

    /// <summary>
    /// Шаг по напряжению при переключении на смежное ответвление, в процентах от номинального напряжения вывода силового трансформатора, %.		
    /// </summary>
    public float? voltageStepIncrement
    {
        get => GetAttribute<float?>(nameof(voltageStepIncrement));
        set => SetAttribute(nameof(voltageStepIncrement), value);
    }

    /// <summary>
    /// Максимальное индуктивное сопротивление луча звезды, Ом.		
    /// </summary>
    public float? xMax
    {
        get => GetAttribute<float?>(nameof(xMax));
        set => SetAttribute(nameof(xMax), value);
    }

    /// <summary>
    /// Минимальное индуктивное сопротивление луча звезды, Ом.
    /// </summary>
    public float? xMin
    {
        get => GetAttribute<float?>(nameof(xMin));
        set => SetAttribute(nameof(xMin), value);
    }
}
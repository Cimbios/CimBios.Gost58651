using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Динамические параметры вращающейся электрической машины.
/// </summary>
[CimClass(ClassUri)]
public partial class RotatingMachineDynamics(IOIDDescriptor oid, ICimMetaClass metaClass)
    : DynamicsFunctionBlock(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#RotatingMachineDynamics";

    /// <summary>
    /// Постоянная инерции генератора, приведенная к его полной мощности, с.
    /// </summary>
    public float? inertia
    {
        get => GetAttribute<float?>(nameof(inertia));
        set => SetAttribute(nameof(inertia), value);
    }

    /// <summary>
    /// Реактивное сопротивление рассеяния Xs, о.е.
    /// </summary>
    public float? statorLeakageReactance
    {
        get => GetAttribute<float?>(nameof(statorLeakageReactance));
        set => SetAttribute(nameof(statorLeakageReactance), value);
    }
}
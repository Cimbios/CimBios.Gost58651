using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Технические параметры электрической вращающейся машины.
/// </summary>
[CimClass(ClassUri)]
public partial class RotatingMachineInfo(IOIDDescriptor oid, ICimMetaClass metaClass)
    : AssetInfo(oid, metaClass)
{
    public new const string ClassUri = "http://gost.ru/2019/schema-cim01#RotatingMachineInfo";

    /// <summary>
    /// Маховой момент ротора генератора, т &#183; м2.
    /// </summary>
    public float? rotorGD2
    {
        get => GetAttribute<float?>(nameof(rotorGD2));
        set => SetAttribute(nameof(rotorGD2), value);
    }
}
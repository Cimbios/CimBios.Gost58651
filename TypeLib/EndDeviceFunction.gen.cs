using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Функция, выполняемая конечным устройством, таким как прибор учета, коммуникационное оборудование, контроллеры и т. д.
/// </summary>
[CimClass(ClassUri)]
public partial class EndDeviceFunction(IOIDDescriptor oid, ICimMetaClass metaClass)
    : AssetFunction(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#EndDeviceFunction";

    /// <summary>
    /// TRUE, если функция включена.
    /// </summary>
    public bool? enabled
    {
        get => GetAttribute<bool?>(nameof(enabled));
        set => SetAttribute(nameof(enabled), value);
    }

    /// <summary>
    /// Конечное устройство, выполняющее одну или несколько функций.
    /// </summary>
    public EndDevice? EndDevice
    {
        get => GetAssoc1To1<EndDevice>(nameof(EndDevice));
        set => SetAssoc1To1(nameof(EndDevice), value);
    }

    /// <summary>
    /// Регистры величин, измеряемых функцией конечного устройства.
    /// </summary>
    public Register[] Registers => GetAssoc1ToM<Register>(nameof(Registers));

    public void AddToRegisters(Register assocObject) => AddAssoc1ToM(nameof(Registers), assocObject);
    public void RemoveFromRegisters(Register assocObject) => RemoveAssoc1ToM(nameof(Registers), assocObject);
    public void RemoveAllFromRegisters() => RemoveAllAssocs1ToM(nameof(Registers));
}
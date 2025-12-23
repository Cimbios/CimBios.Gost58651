using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Первичный двигатель.
/// </summary>
[CimClass(ClassUri)]
public partial class PrimeMover(IOIDDescriptor oid, ICimMetaClass metaClass)
    : PowerSystemResource(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#PrimeMover";

    /// <summary>
    /// Номинальная активная мощность турбины, МВт.
    /// </summary>
    public float? ratedPower
    {
        get => GetAttribute<float?>(nameof(ratedPower));
        set => SetAttribute(nameof(ratedPower), value);
    }

    /// <summary>
    /// Номинальная частота вращения турбины, об/с.
    /// </summary>
    public float? rotationSpeed
    {
        get => GetAttribute<float?>(nameof(rotationSpeed));
        set => SetAttribute(nameof(rotationSpeed), value);
    }

    /// <summary>
    /// Маховой момент турбины, т &#183; м<sup>2</sup>.
    /// </summary>
    public float? rotorGD2
    {
        get => GetAttribute<float?>(nameof(rotorGD2));
        set => SetAttribute(nameof(rotorGD2), value);
    }

    /// <summary>
    /// Асинхронный генератор, соединенный с первичным двигателем.
    /// </summary>
    public AsynchronousMachine? AsynchronousMachine
    {
        get => GetAssoc1To1<AsynchronousMachine>(nameof(AsynchronousMachine));
        set => SetAssoc1To1(nameof(AsynchronousMachine), value);
    }

    /// <summary>
    /// Синхронный генератор, соединенный с первичным двигателем.
    /// </summary>
    public SynchronousMachine[] SynchronousMachines => GetAssoc1ToM<SynchronousMachine>(nameof(SynchronousMachines));

    public void AddToSynchronousMachines(SynchronousMachine assocObject) =>
        AddAssoc1ToM(nameof(SynchronousMachines), assocObject);

    public void RemoveFromSynchronousMachines(SynchronousMachine assocObject) =>
        RemoveAssoc1ToM(nameof(SynchronousMachines), assocObject);

    public void RemoveAllFromSynchronousMachines() => RemoveAllAssocs1ToM(nameof(SynchronousMachines));
}
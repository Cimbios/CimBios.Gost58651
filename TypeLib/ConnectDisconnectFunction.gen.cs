using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Функция, которая отключает и повторно подключает нагрузку клиента при определенных условиях.
/// </summary>
[CimClass(ClassUri)]
public partial class ConnectDisconnectFunction(IOIDDescriptor oid, ICimMetaClass metaClass)
    : EndDeviceFunction(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#ConnectDisconnectFunction";

    /// <summary>
    /// Запуск кумулятивного подсчета событий подключения или отключения в течение всего срока службы функции или до тех пор, пока значение не будет очищено.
    /// </summary>
    public int? eventCount
    {
        get => GetAttribute<int?>(nameof(eventCount));
        set => SetAttribute(nameof(eventCount), value);
    }

    /// <summary>
    /// TRUE, если функция, указанная в предыдущей позиции, находится в подключенном состоянии.
    /// </summary>
    public bool? isConnected
    {
        get => GetAttribute<bool?>(nameof(isConnected));
        set => SetAttribute(nameof(isConnected), value);
    }

    /// <summary>
    /// Если установлено значение TRUE, коммутатор может отключить службу в конце заданной временной задержки после подачи сигнала отключения. Если установлено значение FALSE, коммутатор может отключить службу сразу же после подачи сигнала об отключении.
    /// </summary>
    public bool? isDelayedDiscon
    {
        get => GetAttribute<bool?>(nameof(isDelayedDiscon));
        set => SetAttribute(nameof(isDelayedDiscon), value);
    }

    /// <summary>
    /// Если установлено значение TRUE и если отключение, указанное в предыдущей позиции, может осуществляться локально, то операция происходит автоматически. В противном случае это происходит вручную.
    /// </summary>
    public bool? isLocalAutoDisconOp
    {
        get => GetAttribute<bool?>(nameof(isLocalAutoDisconOp));
        set => SetAttribute(nameof(isLocalAutoDisconOp), value);
    }

    /// <summary>
    /// Если установлено значение TRUE и если повторное подключение после отключения, указанного в предыдущей позиции, может выполняться локально, то операция происходит автоматически. В противном случае это происходит вручную.
    /// </summary>
    public bool? isLocalAutoReconOp
    {
        get => GetAttribute<bool?>(nameof(isLocalAutoReconOp));
        set => SetAttribute(nameof(isLocalAutoReconOp), value);
    }

    /// <summary>
    /// Если установлено значение TRUE и если отключение, указанное в предыдущей позиции, может управляться удаленно, то операция происходит автоматически. Если установлено значение FALSE и отключением можно управлять удаленно, то операция выполняется вручную.
    /// </summary>
    public bool? isRemoteAutoDisconOp
    {
        get => GetAttribute<bool?>(nameof(isRemoteAutoDisconOp));
        set => SetAttribute(nameof(isRemoteAutoDisconOp), value);
    }

    /// <summary>
    /// Если установлено значение TRUE и если повторное подключение после отключения, указанного в предыдущей позиции, может осуществляться удаленно, то операция происходит автоматически. Если установлено значение FALSE и если повторное подключение может осуществляться удаленно, то операция выполняется вручную.
    /// </summary>
    public bool? isRemoteAutoReconOp
    {
        get => GetAttribute<bool?>(nameof(isRemoteAutoReconOp));
        set => SetAttribute(nameof(isRemoteAutoReconOp), value);
    }

    /// <summary>
    /// Информация о реле включения/отключения.
    /// </summary>
    public RemoteConnectDisconnectInfo? rcdInfo
    {
        get => GetAttribute<RemoteConnectDisconnectInfo?>(nameof(rcdInfo));
        set => SetAttribute(nameof(rcdInfo), value);
    }
}
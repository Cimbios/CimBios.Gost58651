using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Запись произошедшего или запланированного события.		
/// </summary>
[CimClass(ClassUri)]
public partial class ActivityRecord(IOIDDescriptor oid, ICimMetaClass metaClass)
    : IdentifiedObject(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#ActivityRecord";

    /// <summary>
    /// Дата и время создания записи активности [Дата и Время].
    /// </summary>
    public DateTime? createdDateTime
    {
        get => GetAttribute<DateTime?>(nameof(createdDateTime));
        set => SetAttribute(nameof(createdDateTime), value);
    }

    /// <summary>
    /// Причина события, приводящего к записи активности.
    /// </summary>
    public string? reason
    {
        get => GetAttribute<string?>(nameof(reason));
        set => SetAttribute(nameof(reason), value);
    }

    /// <summary>
    /// Уровень серьезности события, приводящего к записи активности.
    /// </summary>
    public string? severity
    {
        get => GetAttribute<string?>(nameof(severity));
        set => SetAttribute(nameof(severity), value);
    }

    /// <summary>
    /// Информация о последствиях события, приведшего к записи активности.
    /// </summary>
    public Status? status
    {
        get => GetAttribute<Status?>(nameof(status));
        set => SetAttribute(nameof(status), value);
    }

    /// <summary>
    /// Тип события, приводящего к записи активности.
    /// </summary>
    public string? type
    {
        get => GetAttribute<string?>(nameof(type));
        set => SetAttribute(nameof(type), value);
    }


    /// <summary>
    /// Материальные объекты, для которых была создана запись активности.
    /// </summary>
    public Asset[] Assets => GetAssoc1ToM<Asset>(nameof(Assets));

    public void AddToAssets(Asset assocObject) => AddAssoc1ToM(nameof(Assets), assocObject);
    public void RemoveFromAssets(Asset assocObject) => RemoveAssoc1ToM(nameof(Assets), assocObject);
    public void RemoveAllFromAssets() => RemoveAllAssocs1ToM(nameof(Assets));
}
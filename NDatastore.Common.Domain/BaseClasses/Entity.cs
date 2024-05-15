using System.ComponentModel.DataAnnotations.Schema;
using MediatR;

namespace NDatastore.Common.Domain.BaseClasses;

public abstract class Entity

{
    [DatabaseGenerated((DatabaseGeneratedOption.Identity))]
    public virtual Guid Id { get; protected set; }
    private int? _requestedHashCode;
    public List<INotification> DomainEvents { get; private set; }

    public void AddDomainEvent(INotification eventItem)
    {
        DomainEvents = DomainEvents ?? new List<INotification>();
        DomainEvents.Add(eventItem);
    }

    public void RemoveDomainEvent(INotification eventItem)
    {
        DomainEvents?.Remove(eventItem);
    }

    public void ClearDomainEvents()
    {
        DomainEvents?.Clear();
    }

    public bool IsTransient()
    {
        return this.Id == default;
    }

    public override bool Equals(object? obj)
    {
        if (obj is not Entity)
            return false;

        if (Object.ReferenceEquals(this, obj))
            return true;

        if (this.GetType() != obj.GetType())
            return false;

        Entity item = (Entity)obj;

        if (item.IsTransient() || this.IsTransient())
            return false;
        else
            return item.Id == this.Id;
    }

    public override int GetHashCode()
    {
        if (IsTransient())
        {
            return base.GetHashCode();
        }

        _requestedHashCode ??= this.Id.GetHashCode() ^ 31;
        return _requestedHashCode.Value;
    }

    public static bool operator ==(Entity left, Entity right)
    {
        if (Object.Equals(left, null))
            return (Object.Equals(right, null)) ? true : false;
        else
            return left.Equals(right);
    }

    public static bool operator !=(Entity left, Entity right)
    {
        return !(left == right);
    }
}
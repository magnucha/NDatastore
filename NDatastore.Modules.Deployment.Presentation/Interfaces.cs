using Datastore.Modules.Deployment.Domain.Events;
using MediatR;

namespace NDatastore.Modules.Deployment.Presentation;

public interface IHandleSiteCreatedEvent : INotificationHandler<SiteCreatedEvent>;
public interface IHandleFieldCreatedEvent : INotificationHandler<FieldCreatedEvent>;
﻿namespace NDatastore.Common.Domain.Interfaces;

public interface IRepository<T> where T : IAggregateRoot
{
    IUnitOfWork UnitOfWork { get; }
}
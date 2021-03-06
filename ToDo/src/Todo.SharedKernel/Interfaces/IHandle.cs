﻿using System.Threading.Tasks;
using Todo.SharedKernel;

namespace Todo.SharedKernel.Interfaces
{
    public interface IHandle<in T> where T : BaseDomainEvent
    {
        Task Handle(T domainEvent);
    }
}
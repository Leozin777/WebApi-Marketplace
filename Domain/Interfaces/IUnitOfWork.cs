using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IUnitOfWork
    {
        Task CommitAsync();

        IClientRepository ClientRepository {get;}
        IItemRepository ItemRepository {get;}
        IStoreRepository IStoreRepository { get; }
    }
}
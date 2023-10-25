using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Repository;
using Domain.Interfaces;
using Persistence.Data;

namespace Application.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly ShopApiContext _context;
        private IRolRepository _roles;
        private IUserRepository _users;

        public UnitOfWork(ShopApiContext context)
        {
            _context = context;
        }
        public IRolRepository Roles
        {
            get
            {
                if (_roles == null)
                {
                    _roles = new RolRepository(_context);
                }
                return _roles;
            }
        }

        public IUserRepository Users
        {
            get
            {
                if (_users == null)
                {
                    _users = new UserRepository(_context);
                }
                return _users;
            }
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
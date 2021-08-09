using POS.DbEntities;
using POS.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationLayer
{
    public class NewEntityHandler<TEntity, TRepository> where TEntity : new() where TRepository : IRepository<TEntity>, new()
    {
        public NewEntityHandler()
        {
            Entity = new TEntity();
        }

        public event EventHandler NewEntitySavedEventHandler;
        public TEntity Entity { get; }
        public bool IsSaved { get; private set; }

        public virtual void Save()
        {
            if (IsSaved)
            {
                throw new Exception("Entity Is already Saved, Cannot Save Twice");
            }

            TRepository entityRepository = new TRepository();
            entityRepository.Add(Entity);
            IsSaved = true;
            OnEntitySaved();
        }

        private void OnEntitySaved()
        {
            IsSaved = true;
            NewEntitySavedEventHandler?.Invoke(this, EventArgs.Empty);
        }
    }
}

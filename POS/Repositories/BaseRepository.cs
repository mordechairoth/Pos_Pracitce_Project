using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Inflector;


namespace POS.Repositories
{
    public abstract class BaseRepository<TEntityModel, TViewModel> where TEntityModel : new() where TViewModel : new()
    {

        public IEnumerable<TViewModel> All()
        {
            var entities = DbHelper.GetAllRows<TEntityModel>(GetTableName());

            return entities.Select(x => EntityModelToViewModel(x));
        }

        public TViewModel Find(int id)
        {
            using var connection = DbHelper.GetNewSqlConnection();
            var findSqlQuery = DbHelper.GetFindByColumnSqlString(GetTableName(), GetTableIdColumnName(), id.ToString());
            var entity = connection.Query<TEntityModel>(findSqlQuery);

            try
            {
                return EntityModelToViewModel(entity.First());
            }
            catch (Exception)
            {
                throw new KeyNotFoundException($"No entity with Id ${id} found.");
            }
        }

        public void Add(TViewModel EntityVm)
        {
            TEntityModel entity = ViewModelToEntityModel(EntityVm);

            using var connection = DbHelper.GetNewSqlConnection();
            var insertSqlCommand = DbHelper.GetInsertSqlString(GetTableName(), GetWritableTableProperties().ToArray());
            connection.ExecuteScalar(insertSqlCommand, entity);
        }

        protected TEntityModel ViewModelToEntityModel(TViewModel viewModel)
        {
            PropertyInfo[] vmProperties = viewModel.GetType().GetProperties();
            TEntityModel enitityModel = new TEntityModel();

            foreach (var property in vmProperties)
            {
                bool hasNotMappedToEntityClassAttribute = property.GetCustomAttributes(typeof(NotMappedToEntityClassAttribute), false).Length > 0;
                if (!hasNotMappedToEntityClassAttribute)
                {
                   enitityModel.GetType().GetProperty(property.Name).SetValue(enitityModel, property.GetValue(viewModel));
                }
            }

            return enitityModel;
        }

        protected TViewModel EntityModelToViewModel(TEntityModel entityModel)
        {
            PropertyInfo[] entityModelProperties = entityModel.GetType().GetProperties();
            IEnumerable<string> vmPropertyNames = typeof(TViewModel).GetProperties().Select(p => p.Name);
            TViewModel viewModel = new TViewModel();

            foreach (var property in entityModelProperties)
            {
                if (vmPropertyNames.Contains(property.Name))
                {
                    viewModel.GetType().GetProperty(property.Name).SetValue(viewModel, property.GetValue(entityModel));
                }
                    
            }

            return viewModel;
        }

        protected string GetTableName()
        {
            return typeof(TEntityModel).Name;
        }

        /// <summary>
        /// returns an array of all column names of a table that can be written to from code, 
        /// this will not include columns names that have the NotMappedWrite attribute
        /// </summary>
        /// <returns>all columns that should be written to be the code</returns>
        protected IEnumerable<string> GetWritableTableProperties()
        {
            PropertyInfo[] alltableProperties = typeof(TEntityModel).GetProperties();

            foreach (var property in alltableProperties)
            {
                bool hasNotMappedWriteAttribute = property.GetCustomAttributes(typeof(NotMappedWriteAttribute), false).Length > 0;
                if (!hasNotMappedWriteAttribute)
                {
                    yield return property.Name;
                }
            }
        }

        /// <summary>
        /// Checks if there is a property named like the singular table name with Id,
        /// or if there is a property named id and returns that propery name
        /// </summary>
        /// <returns>The property name of the id column, returns null if no such property is found</returns>
        protected string GetTableIdColumnName()
        {
            string singularTableName = typeof(TEntityModel).Name.Singularize();
            string idColumnName = singularTableName.Pascalize() + "Id";
            var tableColumnNames = typeof(TEntityModel).GetProperties().Select(x => x.Name);
            if (tableColumnNames.Contains(idColumnName))
            {
                return idColumnName;
            }

            if (tableColumnNames.Contains("Id"))
            {
                return "Id";
            }

            return null;
        }
        
    }
}

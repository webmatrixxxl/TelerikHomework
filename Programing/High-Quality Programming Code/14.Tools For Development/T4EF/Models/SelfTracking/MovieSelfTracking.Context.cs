﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Data.EntityClient;
using System.Data.Metadata.Edm;
using System.Data.Objects.DataClasses;
using System.Data.Objects;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Linq;

namespace T4EF.Models.SelfTracking
{
    public partial class MovieReviewEntities : ObjectContext
    {
        public const string ConnectionString = "name=MovieReviewEntities";
        public const string ContainerName = "MovieReviewEntities";
    
        #region Constructors
    
        public MovieReviewEntities()
            : base(ConnectionString, ContainerName)
        {
            Initialize();
        }
    
        public MovieReviewEntities(string connectionString)
            : base(connectionString, ContainerName)
        {
            Initialize();
        }
    
        public MovieReviewEntities(EntityConnection connection)
            : base(connection, ContainerName)
        {
            Initialize();
        }
    
        private void Initialize()
        {
            // Creating proxies requires the use of the ProxyDataContractResolver and
            // may allow lazy loading which can expand the loaded graph during serialization.
            ContextOptions.ProxyCreationEnabled = false;
            ObjectMaterialized += new ObjectMaterializedEventHandler(HandleObjectMaterialized);
        }
    
        private void HandleObjectMaterialized(object sender, ObjectMaterializedEventArgs e)
        {
            var entity = e.Entity as IObjectWithChangeTracker;
            if (entity != null)
            {
                bool changeTrackingEnabled = entity.ChangeTracker.ChangeTrackingEnabled;
                try
                {
                    entity.MarkAsUnchanged();
                }
                finally
                {
                    entity.ChangeTracker.ChangeTrackingEnabled = changeTrackingEnabled;
                }
                this.StoreReferenceKeyValues(entity);
            }
        }
    
        #endregion
    
        #region ObjectSet Properties
    
        public ObjectSet<Movie> Movies
        {
            get { return _movies  ?? (_movies = CreateObjectSet<Movie>("Movies")); }
        }
        private ObjectSet<Movie> _movies;
    
        public ObjectSet<Review> Reviews
        {
            get { return _reviews  ?? (_reviews = CreateObjectSet<Review>("Reviews")); }
        }
        private ObjectSet<Review> _reviews;

        #endregion
    }
}

﻿namespace ElasticAnalytics.Repository.Elasticsearch.Client
{
    using ElasticAnalytics.Repository.Elasticsearch.PersistenceModel;
    using ElasticAnalytics.Repository.Elasticsearch.QueryContext;
    using ElasticAnalytics.Service.Types;

    using Nest;

    public interface IEsClient
    {
        IIndexResponse Create<T>(IQueryContext qCtx, T doc, ISystemContext ctx) where T : class, IEsDoc;

        IGetResponse<T> Get<T>(IQueryContext qCtx, string id, ISystemContext ctx) where T : class, IEsDoc;

        IIndexResponse Save<T>(IQueryContext qCtx, T doc, ISystemContext ctx, long version = -1) where T : class, IEsDoc;

        IDeleteResponse Delete<T>(IQueryContext qCtx, string id, ISystemContext ctx, long version = -1);
    }
}

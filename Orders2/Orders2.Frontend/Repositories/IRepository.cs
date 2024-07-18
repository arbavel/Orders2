namespace Orders2.Frontend.Repositories
{
    public interface IRepository
    {
        Task<HttpResponseWrapper<object>> GetAsync(string url);

        Task<HttpResponseWrapper<object>> PostAsync<T>(string url, T model);

        Task<HttpResponseWrapper<TActionResponse>> PostAsync<T, TActionResponse>(string url, T model);

    }
}

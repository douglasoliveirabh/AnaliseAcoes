

namespace  AnaliseAcoes.Scrapper.Scrappers {

    public interface IScrapper<TEntity> where TEntity : class{
        TEntity ExecuteScrap(string html);
    }


}
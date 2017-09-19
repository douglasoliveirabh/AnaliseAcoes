

using System.Collections.Generic;

namespace  AnaliseAcoes.Scrapper.Scrappers {

    public interface IScrapper<TEntity> where TEntity : class{
        IEnumerable<TEntity> ExecuteScrap();
    }


}
/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：文章分类接口实现                                                    
*│　作    者：yilezhu                                            
*│　版    本：1.0    模板代码自动生成                                                
*│　创建时间：2019-01-05 17:54:04                             
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间： Czar.Cms.Repository.SqlServer                                  
*│　类    名： ArticleCategoryRepository                                      
*└──────────────────────────────────────────────────────────────┘
*/
using Czar.Cms.Core.DbHelper;
using Czar.Cms.Core.Models;
using Czar.Cms.Core.Options;
using Czar.Cms.Core.Repository;
using Czar.Cms.IRepository;
using Czar.Cms.Models;
using Dapper;
using Microsoft.Extensions.Options;
using System;
using System.Threading.Tasks;

namespace Czar.Cms.Repository.SqlServer
{
    public class ArticleCategoryRepository : BaseRepository<ArticleCategory, Int32>, IArticleCategoryRepository
    {
        public ArticleCategoryRepository(IOptionsSnapshot<DbOption> options):base(options)
        {
            //this.configName = Czar.Cms.Core.Models.DBConfig.MysqlCon;            
        }
       

        public int DeleteLogical(int[] ids)
        {
            string sql = "update articlecategory set IsDelete=1 where Id in @Ids";
            return _dbConnection.Execute(sql, new
            {
                Ids = ids
            });
        }

        public async Task<int> DeleteLogicalAsync(int[] ids)
        {
            string sql = "update articlecategory set IsDelete=1 where Id in @Ids";
            return await _dbConnection.ExecuteAsync(sql, new
            {
                Ids = ids
            });
        }

    }
}
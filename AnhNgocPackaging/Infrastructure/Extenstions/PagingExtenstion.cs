namespace AnhNgocPackaging.Infrastructure.Extenstions
{
    public static class PagingExtenstion
    {
        //used by LINQ to SQL
        public static IQueryable<TSource> Paging<TSource>(this IQueryable<TSource> source, int skip = 0, int limit = 10)
        {
            return source.Skip(skip).Take(limit);
        }

        //used by LINQ
        public static IEnumerable<TSource> Paging<TSource>(this IEnumerable<TSource> source, int skip = 0, int limit = 10)
        {
            return source.Skip(skip).Take(limit);
        }
    }
}

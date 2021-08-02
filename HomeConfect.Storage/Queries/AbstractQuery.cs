namespace HomeConfect.Storage.Queries
{
    public abstract class AbstractQuery
    {
        protected Context Context;

        public AbstractQuery(Context context)
        {
            Context = context;
        }
    }
}

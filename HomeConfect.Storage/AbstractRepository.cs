namespace HomeConfect.Storage
{
    public abstract class AbstractRepository
    {
        protected Context Context;

        public AbstractRepository(Context context)
        {
            Context = context;
        }
    }
}

namespace WebApplication1.Models
{
    public class Paginator<T> where T : class
    {
        public List<T> list;
        public int index; 
        public int totalPages => (int)Math.Ceiling((totalCount - 1) / (double)pageSize);
        public int pageSize;
        public int totalCount;

    }
}

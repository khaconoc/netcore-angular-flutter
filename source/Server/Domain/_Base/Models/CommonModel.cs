using System.Collections.Generic;

namespace Domain._Base.Models
{
    public interface IPagingModel
    {
        long? Count { get; set; }
        int? Page { get; set; }
        int? Size { get; set; }
        Dictionary<string, bool> Order { get; set; }
    }

    public class PagingModel : IPagingModel
    {
        public long? Count { get; set; }
        public int? Page { get; set; }
        public int? Size { get; set; }
        public Dictionary<string, bool> Order { get; set; }
    }

    public class PagingResultModel<T>
    {
        public T[] Data { get; set; }

        public PagingModel Paging { get; set; }
    }

    public class ComboboxModel<T>
    {
        public T Value { get; set; }

        public string Text { get; set; }

        public T Parent { get; set; }
    }
}
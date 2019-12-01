using System.Collections.Generic;

namespace easy_immo_framework.Interface
{
    public interface ITextParser
    {
        List<T> Parse<T>(string filename, string delimiter) where T : IModel, new();
    }
}
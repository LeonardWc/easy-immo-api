using easy_immo_framework.Interface;
using System.Collections.Generic;
using System.IO;

namespace easy_immo_framework.Data
{
    public class TextParser : ITextParser
    {
        public List<T> Parse<T>(string filename, string delimiter) where T : IModel, new()
        {
            List<T> result = new List<T>();
            using (StreamReader reader = File.OpenText(filename))
            {
                //Remove the headline
                string headerLine = reader.ReadLine();
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] items = line.Split(delimiter);
                    T model = (T)new T().Build(items);
                    if (model == null)
                        continue;
                    result.Add(model);
                }
            }
            return result;
        }
    }
}
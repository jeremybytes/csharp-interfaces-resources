using System;

namespace CatalogSaver
{
    public interface ISaveable
    {
        void Save();
    }

    public class Catalog : ISaveable
    {
        void ISaveable.Save()
        {
            Console.WriteLine("Saved");
        }
    }
}

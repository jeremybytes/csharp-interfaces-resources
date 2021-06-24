namespace CatalogSaver
{
    class Program
    {
        static void Main(string[] args)
        {
            Catalog catalog = new Catalog();
            //catalog.Save();

            ISaveable saveable = new Catalog();
            saveable.Save();

            ((ISaveable)catalog).Save();

            var implicitCatalog = new Catalog();
            //implicitCatalog.Save();
        }
    }
}

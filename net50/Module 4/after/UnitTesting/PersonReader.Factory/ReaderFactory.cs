using Microsoft.Extensions.Configuration;
using PersonReader.Interface;
using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace PersonReader.Factory
{
    public class ReaderFactory
    {
        private IConfiguration Configuration;
        public ReaderFactory(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        private IPersonReader? reader;

        public IPersonReader GetReader()
        {
            if (reader != null)
                return reader;

            // Check configuration
            string? readerAssemblyName = Configuration["DataReader:ReaderAssembly"];
            string readerLocation = AppDomain.CurrentDomain.BaseDirectory
                                    + "ReaderAssemblies"
                                    + Path.DirectorySeparatorChar
                                    + readerAssemblyName;

            // Load the assembly
            ReaderLoadContext loadContext = new ReaderLoadContext(readerLocation);
            AssemblyName assemblyName = new AssemblyName(Path.GetFileNameWithoutExtension(readerLocation));
            Assembly readerAssembly = loadContext.LoadFromAssemblyName(assemblyName);

            // Look for the type
            string? readerTypeName = Configuration["DataReader:ReaderType"];
            Type readerType = readerAssembly.ExportedTypes
                                .First(t => t.FullName == readerTypeName);

            // Create the data reader
            reader = Activator.CreateInstance(readerType) as IPersonReader;
            if (reader is null)
            {
                throw new InvalidOperationException(
                    $"Unable to create instance of {readerType} as IPersonReader");
            }

            // Return the data reader
            return reader;
        }
    }
}

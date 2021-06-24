using System;
using System.Reflection;
using System.Runtime.Loader;

namespace PersonReader.Factory
{
    public class ReaderLoadContext : AssemblyLoadContext
    {
        private AssemblyDependencyResolver _resolver;

        public ReaderLoadContext(string readerLocation)
        {
            _resolver = new AssemblyDependencyResolver(readerLocation);
        }

        protected override Assembly? Load(AssemblyName assemblyName)
        {
            string? assemblyPath = _resolver.ResolveAssemblyToPath(assemblyName);
            if (assemblyPath != null)
            {
                return LoadFromAssemblyPath(assemblyPath);
            }

            return null;
        }

        protected override IntPtr LoadUnmanagedDll(string unmanagedDllName)
        {
            string? libraryPath = _resolver.ResolveUnmanagedDllToPath(unmanagedDllName);

            if (libraryPath != null)
            {
                return LoadUnmanagedDllFromPath(libraryPath);
            }

            return IntPtr.Zero;
        }
    }
}

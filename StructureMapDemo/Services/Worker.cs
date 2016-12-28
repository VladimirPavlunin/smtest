using System.Diagnostics;

namespace StructureMapDemo.Services
{
    public class Worker: IWorker
    {
        private bool _disposed = false;

        public void DoWork()
        {
            Trace.Write("Hey from worker");
        }

        public void Dispose()
        {
            _disposed = true;
        }
    }
}
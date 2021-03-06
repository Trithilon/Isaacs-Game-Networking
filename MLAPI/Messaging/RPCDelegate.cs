using System.IO;

namespace MLAPI.Messaging
{
    /// <summary>
    /// Delegate definition for performance RPC's.
    /// </summary>
    public delegate void RPCDelegate(ulong clientID, Stream stream);
}
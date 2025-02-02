using System.Collections.Generic;
using Unity.Netcode;

namespace TestProject.ManualTests
{
    public class InSceneParentedUnderGameObjectHandler : NetworkBehaviour
    {
        static public List<InSceneParentedUnderGameObjectHandler> Instances = new List<InSceneParentedUnderGameObjectHandler>();

        public override void OnNetworkSpawn()
        {
            if (IsServer)
            {
                Instances.Add(this);
            }
        }
    }
}

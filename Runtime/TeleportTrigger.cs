using UnityEngine;
using System.Collections;

namespace HemdemGames.Teleport
{
    public class TeleportTrigger : MonoBehaviour
    {
        [SerializeField] private TeleporterData teleporter;

        public TeleportTriggerEvent OnTeleport;

        private void OnTriggerEnter(Collider other)
        {
            teleporter.Teleport(other.transform);
            OnTeleport?.Invoke(other.transform);
        }
    }
}
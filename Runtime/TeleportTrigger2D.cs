using UnityEngine;
using System.Collections;
using UnityEngine.Events;

namespace HemdemGames.Teleport
{
    public class TeleportTrigger2D : MonoBehaviour
    {
        [SerializeField] private TeleporterData teleporter;

        public TeleportTriggerEvent OnTrigger;

        private void OnTriggerEnter2D(Collider2D other)
        {
            OnTrigger?.Invoke(other.transform);
        }
    }
}
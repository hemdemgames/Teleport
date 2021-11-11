using System;
using UnityEngine;

namespace HemdemGames.Teleport
{
    public class TeleportDestination : MonoBehaviour
    {
        [SerializeField] private TeleportDestinationData teleport;

        private void OnEnable()
        {
            teleport.SetDestination(transform);
        }

        private void OnDisable()
        {
            if (teleport.GetDestination() == transform)
            {
                teleport.ClearDestination();
            }
        }
    }
}


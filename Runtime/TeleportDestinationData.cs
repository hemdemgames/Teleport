using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HemdemGames.Teleport
{
    [CreateAssetMenu(menuName = "Teleport/Destination")]
    public class TeleportDestinationData : ScriptableObject
    {
        private Transform destination;

        public void SetDestination(Transform destination)
        {
            this.destination = destination;
        }

        public Transform GetDestination()
        {
            return destination;
        }

        public void ClearDestination()
        {
            destination = null;
        }

        public Vector3 GetPosition()
        {
            if (!destination)
            {
                throw new DestinationNotFoundException();
            }

            return destination.position;
        }

        public Quaternion GetRotation()
        {
            if (!destination)
            {
                throw new DestinationNotFoundException();
            }

            return destination.rotation;
        }
    }
}
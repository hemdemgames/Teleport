using UnityEngine;
using System.Collections;

namespace HemdemGames.Teleport
{
    [CreateAssetMenu(menuName = "Teleport/Teleporter")]
    public class TeleporterData : ScriptableObject
    {
        [SerializeField] private TeleportDestinationData destination;

        public void Teleport(Transform gameObject)
        {
            gameObject.position = destination.GetPosition();
            gameObject.rotation = destination.GetRotation();
        }
    }
}
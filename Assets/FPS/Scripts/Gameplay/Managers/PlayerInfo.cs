using Unity.FPS.Game;
using UnityEngine;
using UnityEngine.Events;

namespace Unity.FPS.Gameplay
{
    public class PlayerInfo : MonoBehaviour
    {
        [Header("Points")]
        [Tooltip("The cost in points a player must pay to open the door.")]
        public int PlayerPoints = 500;
        void Awake()
        {
        }

        void Start()
        {
        }

        void Update()
        {
        }

        public int GetPlayerPoints() {
            return PlayerPoints;
        }
    }
}
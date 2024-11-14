using Unity.FPS.Game;
using UnityEngine;
using UnityEngine.Events;

namespace Unity.FPS.Gameplay
{
    public class PlayerInfo : MonoBehaviour
    {
        [Header("Total Points")]
        [Tooltip("The total amount of points the player has had for the duration of the current session.")]
        public int TotalPlayerPoints = 500;

        [Header("Current Points")]
        [Tooltip("The current amount of points the player has.")]
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

        public void DeductPlayerPoints(int deductionAmount) {
            if (PlayerPoints - deductionAmount >= 0) {
                PlayerPoints -= deductionAmount;
            }
        }
    }
}
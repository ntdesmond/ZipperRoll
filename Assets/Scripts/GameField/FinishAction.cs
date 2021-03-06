using Player;
using UnityEngine;

namespace GameField
{
    public class FinishAction : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (!other.TryGetComponent<PlayerMovement>(out var playerMovement))
            {
                return;
            }
            Debug.Log("Yay!");
            playerMovement.enabled = false;
        }
    }
}

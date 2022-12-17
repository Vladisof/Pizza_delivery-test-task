using UnityEngine;

namespace DefaultNamespace
{
    public class FinishChecker : MonoBehaviour
    {
        [SerializeField] private string _checkingObjectTag;
        [SerializeField] private PlayerMoving _playerMoving;
        [SerializeField] private GameObject _congratulationUI;
        
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag(_checkingObjectTag))
            {
                _congratulationUI.SetActive(true);
                _playerMoving.StopAnim(0);
                _playerMoving.enabled = false;
            }
        }
    }
}
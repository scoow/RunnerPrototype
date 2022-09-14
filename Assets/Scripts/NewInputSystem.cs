using UnityEngine;

namespace TopEngineTeam
{
    /*
    Новая система ввода
    */
    public class NewInputSystem : MonoBehaviour
    {
        private Controls controlManager;

        protected void OnEnable()
        {
           controlManager = new();
           controlManager.Enable();
           controlManager.PlayerControls.Jump.started += callbackContext => Player.currentPlayer.Jump();
        }
        private void Update()
        {
            Player.currentPlayer.MoveLeftOrRight(controlManager.PlayerControls.AD.ReadValue<float>());
        }
        private void OnDisable() => controlManager.Disable();
    }
}

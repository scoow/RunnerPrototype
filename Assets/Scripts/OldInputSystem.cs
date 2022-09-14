using UnityEngine;

namespace TopEngineTeam
{
    /*
    Старая система ввода
    */
    public class OldInputSystem : MonoBehaviour
    {
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Player.currentPlayer.Jump();
            }

            Player.currentPlayer.MoveLeftOrRight(Input.GetAxis("Horizontal"));
        }
    }
}
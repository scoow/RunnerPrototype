using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerComponent : MonoBehaviour
{   
    [SerializeField] private TypeOfTrigger _typeOfTrigger;

    [SerializeField] private Player player;

    private void OnTriggerEnter(Collider other)
    {
        player = other.GetComponent<Player>();

        if (player = null)
            return;

        switch (_typeOfTrigger)
        {
            case TypeOfTrigger.DamageTrigger:
                GameManager.instance.DecreaseHP();
                break;
            case TypeOfTrigger.MovingObstacleTrigger:
                break;
            case TypeOfTrigger.SpringboardTrigger:
                //player.Jump();
                other.attachedRigidbody.AddForce(Vector3.up * 12, ForceMode.VelocityChange);
                break;
            case TypeOfTrigger.FallingTrigger:
                GameManager.instance.GameOver();
                break;
            case TypeOfTrigger.EndOfTileTrigger:
                GameManager.instance.IncreaseScore();
                break;
            default:
                break;
        }
    }

    private enum TypeOfTrigger
    {
        DamageTrigger,
        MovingObstacleTrigger,
        SpringboardTrigger,
        FallingTrigger,
        EndOfTileTrigger
    }
}

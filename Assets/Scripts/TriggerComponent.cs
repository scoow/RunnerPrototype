using UnityEngine;
/*
 Проверка вида триггера при столкновении с игроком, выбор действия
*/
public class TriggerComponent : MonoBehaviour
{   
    [SerializeField] private TypeOfTrigger _typeOfTrigger;
    [SerializeField, Range(0, 24)] private float _throwUpForce = 12;
    [SerializeField, Range(0, 24)] private float _throwBackForce = 9;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Player>() is null)
            return;

        switch (_typeOfTrigger)
        {
            case TypeOfTrigger.DamageTrigger:
                GameManager.instance.DecreaseHP();
                Player.currentPlayer.ThrowBack(_throwBackForce);
                break;
            case TypeOfTrigger.MovingObstacleTrigger:
                Player.currentPlayer.ThrowBack(_throwBackForce);
                break;
            case TypeOfTrigger.SpringboardTrigger:
                Player.currentPlayer.ThrowUp(_throwUpForce);
                break;
            case TypeOfTrigger.EndOfTileTrigger:
                GameManager.instance.IncreaseScore();
                Debug.Log("Score");
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
        EndOfTileTrigger
    }
}

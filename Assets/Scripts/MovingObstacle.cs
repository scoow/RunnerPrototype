using System.Collections;
using UnityEngine;

namespace TopEngineTeam
/*
Цикличное движение препятствия с помощью корутин
*/
{
    public class MovingObstacle : MonoBehaviour
    {
        [SerializeField] private float _timeToMove = 3;
        [SerializeField] private float _speedOfPlatform = 3;
        [SerializeField] private float _amplitude = 5;
        void Start()
        {
            StartCoroutine(CyclePlatformMoving());
        }
        private IEnumerator CyclePlatformMoving()
        {
            Vector3 startPosition = transform.position;
            Vector3 endPosition = transform.position + new Vector3(0, _amplitude, 0);
            while (true)
            {
                StartCoroutine(MoveFromStartToEnd(startPosition, endPosition, _speedOfPlatform, _timeToMove));
                yield return new WaitForSeconds(_timeToMove);
                StartCoroutine(MoveFromStartToEnd(endPosition, startPosition, _speedOfPlatform, _timeToMove));
                yield return new WaitForSeconds(_timeToMove);
            }

        }

        private IEnumerator MoveFromStartToEnd(Vector3 startPosition, Vector3 endPosition, float speed, float time)
        {

            float currentTime = 0f;

            while (currentTime < _timeToMove)
            {
                transform.position = Vector3.Lerp(startPosition, endPosition, speed * currentTime / time);
                currentTime += Time.deltaTime;
                yield return null;
            }
            transform.position = endPosition;

        }
    }
}

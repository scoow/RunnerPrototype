using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObstacle : MonoBehaviour
{
    [SerializeField] float _time = 3;
    [SerializeField] float _speed = 3;
    void Start()
    {
        StartCoroutine(CyclePlatformMove(_time));
    }

    private IEnumerator CyclePlatformMove(float time)
    {
        while (true)
        {
            var currentTime = 0f;
            Vector3 startPosition = transform.position;
            Vector3 endPosition = transform.position + new Vector3(0, 5f, 0);
            while (currentTime < time)//асинхронный цикл, выполняется time секунд
            {
                //Lerp - в зависимости от времени (в относительных единицах, то есть от 0 до 1
                //смещает объект от startPosition к endPosition

                transform.position = Vector3.Lerp(startPosition, endPosition, _speed * currentTime / time);//в формулу добавлено влияние скорости персонажа
                currentTime += Time.deltaTime;//обновление времени, для смещения
                yield return null;//ожидание следующего кадра
            }
            //Из-за неточности времени между кадрами, без этой строчки вы не получите точное значение endPosition
            transform.position = endPosition;


            currentTime = 0f;
            while (currentTime < time)//асинхронный цикл, выполняется time секунд
            {
                //Lerp - в зависимости от времени (в относительных единицах, то есть от 0 до 1
                //смещает объект от startPosition к endPosition

                transform.position = Vector3.Lerp(endPosition, startPosition, _speed * currentTime / time);//в формулу добавлено влияние скорости персонажа
                currentTime += Time.deltaTime;//обновление времени, для смещения
                yield return null;//ожидание следующего кадра
            }
            //Из-за неточности времени между кадрами, без этой строчки вы не получите точное значение endPosition
            transform.position = startPosition;
        }


    }

}

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
            while (currentTime < time)//����������� ����, ����������� time ������
            {
                //Lerp - � ����������� �� ������� (� ������������� ��������, �� ���� �� 0 �� 1
                //������� ������ �� startPosition � endPosition

                transform.position = Vector3.Lerp(startPosition, endPosition, _speed * currentTime / time);//� ������� ��������� ������� �������� ���������
                currentTime += Time.deltaTime;//���������� �������, ��� ��������
                yield return null;//�������� ���������� �����
            }
            //��-�� ���������� ������� ����� �������, ��� ���� ������� �� �� �������� ������ �������� endPosition
            transform.position = endPosition;


            currentTime = 0f;
            while (currentTime < time)//����������� ����, ����������� time ������
            {
                //Lerp - � ����������� �� ������� (� ������������� ��������, �� ���� �� 0 �� 1
                //������� ������ �� startPosition � endPosition

                transform.position = Vector3.Lerp(endPosition, startPosition, _speed * currentTime / time);//� ������� ��������� ������� �������� ���������
                currentTime += Time.deltaTime;//���������� �������, ��� ��������
                yield return null;//�������� ���������� �����
            }
            //��-�� ���������� ������� ����� �������, ��� ���� ������� �� �� �������� ������ �������� endPosition
            transform.position = startPosition;
        }


    }

}

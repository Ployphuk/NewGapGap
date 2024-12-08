using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public int questionNumber;   // �Ţ��ͷ���ͧ���
    public int pointsToAdd;     // ���������������͡�����

    public void OnButtonClick()
    {
        var pointsManager = FindObjectOfType<PointsManager>();
        if (pointsManager != null)
        {
            pointsManager.AddPoints(questionNumber, pointsToAdd);
        }
        else
        {
            Debug.LogError("PointsManager not found in the scene!");
        }
    }
}

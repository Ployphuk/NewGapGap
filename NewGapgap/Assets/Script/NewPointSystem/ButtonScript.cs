using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public int questionNumber;   // เลขข้อที่ต้องการ
    public int pointsToAdd;     // แต้มที่จะเพิ่มเมื่อกดปุ่ม

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

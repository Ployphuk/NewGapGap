using UnityEngine;
using System.Collections.Generic;

[System.Serializable]
public class QuestionPoints
{
    public int questionNumber;
    public int points;
}

[System.Serializable]
public class PointsData
{
    public List<QuestionPoints> pointsList = new List<QuestionPoints>();
}

public class PointsManager : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    private string filePath;
    public PointsData pointsData = new PointsData();

    void Start()
    {
        filePath = Application.persistentDataPath + "/pointsData.json";
        LoadPointsData();
    }

    public void LoadPointsData()
    {
        if (System.IO.File.Exists(filePath))
        {
            string json = System.IO.File.ReadAllText(filePath);
            pointsData = JsonUtility.FromJson<PointsData>(json);
        }
    }

    public void SavePointsData()
    {
        string filePath = Application.persistentDataPath + "/pointsData.json";
        string json = JsonUtility.ToJson(pointsData, true);
        Debug.Log("Saving JSON to: " + filePath);
        System.IO.File.WriteAllText(filePath, json);
    }

    public void AddPoints(int questionNumber, int points)
    {
        var existingData = pointsData.pointsList.Find(p => p.questionNumber == questionNumber);
        if (existingData != null)
        {
            existingData.points += points;
        }
        else
        {
            pointsData.pointsList.Add(new QuestionPoints { questionNumber = questionNumber, points = points });
        }

        SavePointsData();
    }

    public int GetPoints(int questionNumber)
    {
        var data = pointsData.pointsList.Find(p => p.questionNumber == questionNumber);
        return data != null ? data.points : 0;
    }
}

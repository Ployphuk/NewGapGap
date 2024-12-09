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
    public int totalPoints;  // New field to store the summary of all points
}

public class PointsManager : MonoBehaviour
{
    private string filePath;
    public PointsData pointsData = new PointsData();

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        filePath = Application.persistentDataPath + "/pointsData.json";
    }

    void Start()
    {
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
        string json = JsonUtility.ToJson(pointsData, true);
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

        // Update total points summary
        pointsData.totalPoints += points;

        SavePointsData();
    }

    public int GetPoints(int questionNumber)
    {
        var data = pointsData.pointsList.Find(p => p.questionNumber == questionNumber);
        return data != null ? data.points : 0;
    }
}

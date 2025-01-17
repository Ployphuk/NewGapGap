using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ResolutionManager : MonoBehaviour
{
    [SerializeField] private TMP_Dropdown resolutionsDropdown;

    private Resolution[] resolutions;
    private List<Resolution> filteredResolutions;

    private float currentRefreshRate;
    private int currentResolutionIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        resolutions = Screen.resolutions;
        filteredResolutions = new List<Resolution>();

        resolutionsDropdown.ClearOptions();
        currentRefreshRate = Screen.currentResolution.refreshRate;

        Debug.Log("refreshRate: " + currentRefreshRate);

        for (int i = 0; i < resolutions.Length; i++)
        {
            Debug.Log("Resolution: " + resolutions[i]);
            float aspectRatio = (float)resolutions[i].width / resolutions[i].height;
            
            // ตรวจสอบว่าอัตราส่วนเป็น 16:9 หรือ 16:10 และ refresh rate ตรงกัน
            if ((Mathf.Approximately(aspectRatio, 16f / 9f) || Mathf.Approximately(aspectRatio, 16f / 10f)) &&
                resolutions[i].refreshRate == currentRefreshRate)
            {
                filteredResolutions.Add(resolutions[i]);
            }
        }

        List<string> options = new List<string>();
        for (int i = 0; i < filteredResolutions.Count; i++)
        {
            string resolutionOption = filteredResolutions[i].width + "x" + filteredResolutions[i].height + " " + filteredResolutions[i].refreshRate + " Hz";
            options.Add(resolutionOption);
            if (filteredResolutions[i].width == Screen.width && filteredResolutions[i].height == Screen.height)
            {
                currentResolutionIndex = i;
            }
        }

        resolutionsDropdown.AddOptions(options);
        resolutionsDropdown.value = currentResolutionIndex;
        resolutionsDropdown.RefreshShownValue();
    }

    // Update is called once per frame
    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = filteredResolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }
}

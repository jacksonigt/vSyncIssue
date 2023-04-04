using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class VSyncEnabler : MonoBehaviour
{
    int vSyncCount;

    public TextMeshProUGUI text;


    // Start is called before the first frame update
    void Start()
    {
        vSyncCount = QualitySettings.vSyncCount;
        SetText();
    }

    public void ClickButton()
    {
        vSyncCount++;
        if (vSyncCount > 3)
        {
            vSyncCount = 0;
        }

        QualitySettings.vSyncCount = vSyncCount;

        SetText();
    }

    private void SetText()
    {
        text.text = $"vSync: {QualitySettings.vSyncCount}";
    }
}

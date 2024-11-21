using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoutDown : MonoBehaviour
{
    private TextMeshProUGUI countText;

    public float time = 90f;
    void Start()
    {
        countText = FindObjectOfType<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        countText.SetText(Mathf.Round(time).ToString());
        time -= Time.deltaTime;
    }
}

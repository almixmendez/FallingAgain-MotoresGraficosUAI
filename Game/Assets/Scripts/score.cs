using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    private float points;
    private TextMeshProUGUI textMesh;
    private float itemsLeft;

    private void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        points += Time.deltaTime;
        textMesh.text = points.ToString("0");
    }

    public void GainPoints(float inputPoints)
    {
        points += inputPoints;
    }
}

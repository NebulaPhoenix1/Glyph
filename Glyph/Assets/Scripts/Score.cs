using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using TMPro;
public class Score : MonoBehaviour
{
    [Header("UI References")]
    [SerializeField] TMP_Text scoreText;
    [SerializeField] Slider timeSlider;

    //Max time before death
    private float maxTime = 3;
    //Time remaining
    private float remainingTime = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        
    }
}

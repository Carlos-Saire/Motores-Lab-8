using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LifePanel : MonoBehaviour
{
    [SerializeField] private TMP_Text lifeText;


    private void OnEnable()
    {
        GameManager.Instance.OnLifeUpdate += OnLifeUpdate;

    }

    private void OnDisable()
    {
        GameManager.Instance.OnLifeUpdate -= OnLifeUpdate;

    }

    private void OnLifeUpdate(int life)
    {
        lifeText.text =""+ life;
    }
}

using TMPro;
using UnityEngine;

public class CoinPanel : MonoBehaviour
{
    [SerializeField] private TMP_Text coinsText;

    private void OnEnable()
    {
        GameManager.Instance.OnCoinUpdate += OnCoinUpdate;

    }
    private void OnDisable()
    {
        GameManager.Instance.OnCoinUpdate -= OnCoinUpdate;

    }  
    private void OnCoinUpdate(int coins)
    {
        coinsText.text =""+ coins;
    }
}

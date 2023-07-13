using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ResourceManager : MonoBehaviour
{
    public static ResourceManager instance;

    [Header("Resourecs Amounts")]
    public float gold;
    public float stone;
    public float wood;
    public float gem;

    [Header("Resourecs Texts")]
    [SerializeField] private TextMeshProUGUI goldText;
    [SerializeField] private TextMeshProUGUI stoneText;
    [SerializeField] private TextMeshProUGUI woodText;
    [SerializeField] private TextMeshProUGUI gemText;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        UpdateTextUI();
    }

    public void UpdateTextUI()
    {
        goldText.text = gold.ToString();
        stoneText.text = stone.ToString();
        woodText.text = wood.ToString();
        gemText.text = gem.ToString();
    }
}
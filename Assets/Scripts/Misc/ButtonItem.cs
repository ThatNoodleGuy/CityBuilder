using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonItem : MonoBehaviour
{
    [SerializeField] Building building;

    private BuildManager buildManager;
    private ResourceManager resourceManager;

    private Button button;
    private float buildingGoldCost;
    private float buildingStoneCost;
    private float buildingWoodCost;
    private float buildingGemCost;

    private void Awake()
    {
        buildManager = BuildManager.instance;
        resourceManager = ResourceManager.instance;
    }

    private void Start()
    {
        button = GetComponent<Button>();
    }

    private void Update()
    {
        if ((ResourceManager.instance.gold < building.GetGoldCost()) ||
            (ResourceManager.instance.wood < building.GetStoneCost()) ||
            (ResourceManager.instance.stone < building.GetWoodCost()) ||
            (ResourceManager.instance.gem < building.GetGemCost()))
        {
            button.interactable = false;
        }
        else
        {
            button.interactable = true;
        }
    }
}
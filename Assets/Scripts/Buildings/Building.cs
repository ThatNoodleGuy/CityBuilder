using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
    [Header("Income")]
    [SerializeField] private float goldIncome;
    [SerializeField] private float stoneIncome;
    [SerializeField] private float woodIncome;
    [SerializeField] private float gemIncome;

    [Header("Cost")]
    [SerializeField] private float goldCost;
    [SerializeField] private float stoneCost;
    [SerializeField] private float woodCost;
    [SerializeField] private float gemCost;

    [Header("References")]
    [SerializeField] private GameObject buildPosition;
    [SerializeField] private float timeBetweenIncomes;

    private float nextIncomeTime;

    private BuildManager buildManager;
    private ResourceManager resourceManager;

    private void Awake()
    {
        buildManager = BuildManager.instance;
        resourceManager = ResourceManager.instance;

        resourceManager.gold -= goldCost;
        resourceManager.stone -= stoneCost;
        resourceManager.wood -= woodCost;
        resourceManager.gem -= gemCost;
    }

    private void Update()
    {
        if (Time.time > nextIncomeTime)
        {
            resourceManager.gold += goldIncome;
            resourceManager.stone += stoneIncome;
            resourceManager.wood += woodIncome;
            resourceManager.gem += gemIncome;
            nextIncomeTime = Time.time + timeBetweenIncomes;
        }
    }

    private void OnMouseDown()
    {
        GameObject buildPoistionGameObject = Instantiate(buildPosition, transform.position, transform.rotation);

        DestroyBuilding();
    }

    private void DestroyBuilding()
    {
        resourceManager.gold += goldCost / 2;
        resourceManager.stone += stoneCost / 2;
        resourceManager.wood += woodCost / 2;
        resourceManager.gem += gemCost / 2;

        Destroy(gameObject);
    }

    public float GetGoldCost()
    {
        return goldCost;
    }

    public float GetStoneCost()
    {
        return stoneCost;
    }

    public float GetWoodCost()
    {
        return woodCost;
    }

    public float GetGemCost()
    {
        return gemCost;
    }
}
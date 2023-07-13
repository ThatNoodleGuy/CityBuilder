using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;

    [SerializeField] private GameObject[] buildings;

    private GameObject buildingToPlace;

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

    public void OnClickButton(int index)
    {
        buildingToPlace = buildings[index];
    }

    public GameObject GetBuildingToPlace()
    {
        return buildingToPlace;
    }

    public void SetBuildingToPlaceToNull()
    {
        buildingToPlace = null;
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildPosition : MonoBehaviour
{
    private BuildManager buildManager;

    private void Awake()
    {
        buildManager = BuildManager.instance;
    }

    private void OnMouseDown()
    {
        if (BuildManager.instance.GetBuildingToPlace() != null)
        {
            GameObject building = Instantiate(BuildManager.instance.GetBuildingToPlace(), transform.position, transform.rotation);
            BuildManager.instance.SetBuildingToPlaceToNull();
            Destroy(gameObject);
        }
    }
}
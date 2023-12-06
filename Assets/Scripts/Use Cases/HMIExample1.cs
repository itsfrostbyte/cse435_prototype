using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HMIExample1 : MonoBehaviour
{
    [SerializeField] private ExampleSceneManager exampleSceneManager;

    [SerializeField] GameObject findSpotButton;
    [SerializeField] GameObject confirmSpot;
    [SerializeField] GameObject findingSpot;
    [SerializeField] GameObject startingManeuver;
    [SerializeField] GameObject maneuverEnded;

    [SerializeField] GameObject obstacleDetected;

    public void FindSpotButtonClicked()
    {
        findSpotButton.SetActive(false);
        findingSpot.SetActive(true);
        StartCoroutine(WaitToFindSpot());
    }

    public void SpotFound()
    {
        confirmSpot.SetActive(true);
    }

    public void ConfirmSpot(bool confirmed)
    {
        confirmSpot.SetActive(false);
        if(confirmed)
        {
            startingManeuver.SetActive(true);
            VehicleManeuver.Instance.StartManeuver();
            //exampleSceneManager.ScenarioEnd();
        }
        else
        {
            findSpotButton.SetActive(true);
        }
    }

    public void ManeuverEnded()
    {
        startingManeuver.SetActive(false);
        maneuverEnded.SetActive(true);
    }

    IEnumerator WaitToFindSpot()
    {
        yield return new WaitForSeconds(2f);
        findingSpot.SetActive(false);
        SpotFound();
    }

    public void ObstacleDetected()
    {
        obstacleDetected.SetActive(true);
        startingManeuver.SetActive(false);
    }

    public void ObstacleMoved()
    {
        obstacleDetected.SetActive(false);
        startingManeuver.SetActive(true);
    }
}

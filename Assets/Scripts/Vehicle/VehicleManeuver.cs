using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Scripting;

public class VehicleManeuver : MonoBehaviour
{
    public static VehicleManeuver Instance;

    [SerializeField] private Animator animator;
    [SerializeField] private HMIExample1 hMIExample1;

    private bool maneuverInProgress = false;

    private void Awake()
    {
        Instance = this;
    }

    public void StartManeuver()
    {
        animator.SetTrigger("startManeuver");
        maneuverInProgress = true;
    }

    public void ManeuverEnd()
    {
        if(hMIExample1 != null)
        {
            hMIExample1.ManeuverEnded();
        }
        ExampleSceneManager.Instance.ScenarioEnd();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log("enter");
        if(other.gameObject.tag == "Player" && maneuverInProgress)
        {
            animator.speed = 0f;
            hMIExample1.ObstacleDetected();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        //Debug.Log("exit");
        if(other.gameObject.tag == "Player" && maneuverInProgress)
        {
            animator.speed = 1f;
            hMIExample1.ObstacleMoved();
        }
    }
}

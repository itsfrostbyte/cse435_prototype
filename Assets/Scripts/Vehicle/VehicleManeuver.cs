using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting;

public class VehicleManeuver : MonoBehaviour
{
    public static VehicleManeuver Instance;

    [SerializeField] private Animator animator;
    [SerializeField] private HMIExample1 hMIExample1;

    private void Awake()
    {
        Instance = this;
    }

    public void StartManeuver()
    {
        animator.SetTrigger("startManeuver");
    }

    public void ManeuverEnd()
    {
        if(hMIExample1 != null)
        {
            hMIExample1.ManeuverEnded();
        }
        ExampleSceneManager.Instance.ScenarioEnd();
    }
}

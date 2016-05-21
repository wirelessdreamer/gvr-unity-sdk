using UnityEngine;
using System.Collections;

public class ZapperInput : MonoBehaviour {
    // Use this for initialization
    GazeInputModule gazeInput;

    void Start () {
        gazeInput = FindObjectOfType<GazeInputModule>();
    }

    // Update is called once per frame
    void Update () {

        
        System.Array values = System.Enum.GetValues(typeof(KeyCode));
        foreach (KeyCode code in values)
        {
            if (Input.GetKeyDown(code))
            {
                gazeInput.HandleTrigger();
            }
        }

        if (Input.GetButtonDown("Fire1"))
        {
            print("trigger pressed");
            gazeInput.HandleTrigger();
        }

        if (Input.GetKeyDown(KeyCode.JoystickButton4))
        {
            print("reload pressed");
        }

    }
}
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;
using UnityEngine.AI;

public class AgentMovement : MonoBehaviour
{
    Camera cam;
    public LayerMask Ground;
    public NavMeshAgent playerAgent;
    #region Monobehaviour API

    void Awake()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            playerAgent.SetDestination(GetPointUnderCursor());
        }
    }

    #endregion
    private Vector3 GetPointUnderCursor()
    {
        Vector2 screenPosition = Input.mousePosition;
        Vector3 mouseWorldPosition = cam.ScreenToWorldPoint(screenPosition);

        RaycastHit hitPosition;
        Physics.Raycast(mouseWorldPosition, cam.transform.forward, out hitPosition, 1000, Ground);
        return hitPosition.point;
    }
}

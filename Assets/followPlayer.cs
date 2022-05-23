using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class followPlayer : MonoBehaviour
{
    public Transform target;
    public Transform targetCamera;
    NavMeshAgent nav;
    Animator anim;
    private Vector3 oldPos;
    private Vector3 actualPos;
    private Coroutine LookCoroutine;
    public float Speed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        nav = GetComponent<NavMeshAgent>();
    }


    // Update is called once per frame
    void Update()
    {
        actualPos = this.transform.position;
        anim.SetBool("Walk_Anim", true);
        nav.SetDestination(targetCamera.position);

        // Determine which direction to rotate towards
        Vector3 targetDirection = target.position - transform.position;

        // The step size is equal to speed times frame time.
        float singleStep = Speed * Time.deltaTime;

        // Rotate the forward vector towards the target direction by one step
        Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirection, singleStep, 0.0f);

        // Draw a ray pointing at our target in
        Debug.DrawRay(transform.position, newDirection, Color.red);

        // Calculate a rotation a step closer to the target and applies rotation to this object
        transform.rotation = Quaternion.LookRotation(newDirection);

        if (oldPos == actualPos)
        {
            anim.SetBool("Walk_Anim", false);
            anim.SetBool("Open_Anim", true);
        }

        oldPos = actualPos;
    }
}

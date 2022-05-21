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

    private IEnumerator LookAt()
    {
        Quaternion lookRotation = Quaternion.LookRotation(targetCamera.position - transform.position);

        float time = 0;

        while (time < 1)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, time);
            time += Time.deltaTime * Speed;

            yield return null;
        }
    }


    public void StartRotating()
    {
        if(LookCoroutine != null)
        {
            StopCoroutine(LookCoroutine);
        }

        LookCoroutine = StartCoroutine(LookAt());
    }


    // Update is called once per frame
    void Update()
    {
        actualPos = this.transform.position;
        anim.SetBool("Walk_Anim", true);
        nav.SetDestination(targetCamera.position);
        //this.transform.LookAt(targetCamera);
        //StartRotating();



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
        //nav.SetDestination(targetCamera.position + new Vector3(5 * targetCamera.rotation.x, targetCamera.rotation.y, 5 * targetCamera.rotation.z));
        //nav.SetDestination(camera.rotation + new Vector3(5, 0, 5));
        // nav.set
    }
}

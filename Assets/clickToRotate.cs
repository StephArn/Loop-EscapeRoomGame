using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickToRotate : MonoBehaviour
{
    [SerializeField]
    private string selectableTag = "rotatables";

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if ( Physics.Raycast(ray, out hit))
            {
                var selection = hit.transform;
                if (selection.CompareTag(selectableTag))
                {
                    var selectionRender = selection.GetComponent<Renderer>();
                    if (selectionRender != null)
                    {
                        hit.collider.transform.Rotate(0, 0, 90);
                    }
                }
            }
        }
    }
}

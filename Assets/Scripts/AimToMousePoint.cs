using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Rendering;

public class AimToMousePoint : MonoBehaviour
{
    //values that will be set in the Inspector
   
    public float RotationSpeed = 2;

    //values for internal use
    Vector3 Target;
    Quaternion _lookRotation;
    Vector3 _direction;

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if(Physics.Raycast(ray, out RaycastHit hitInfo))
        {
            Target = hitInfo.point;

            //find the vector pointing from our position to the target
            _direction = (Target - transform.position).normalized;
            
            //create the rotation we need to be in to look at the target
            _lookRotation = Quaternion.LookRotation(_direction);

            //rotate us over time according to speed until we are in the required rotation
            
            transform.rotation = Quaternion.Slerp(transform.rotation, _lookRotation, Time.deltaTime * RotationSpeed);
            
        }
        
    }
}

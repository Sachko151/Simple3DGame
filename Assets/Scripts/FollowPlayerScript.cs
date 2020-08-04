using UnityEngine;

public class FollowPlayerScript : MonoBehaviour
{
    public Transform target;
     public float movementSpeed = 0.125f;
     public Vector3 offset;

        void LateUpdate()
     {
         transform.position = target.position + offset;

     } 
}

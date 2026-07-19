using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamControl : MonoBehaviour
{
    public Transform lookAt;
    public float boundx = 0.15f;
    public float boundy = 0.05f;

    private void LateUpdate()
    {
        Vector3 delta = Vector3.zero;
        float deltax = lookAt.position.x - transform.position.x;
        if(deltax > boundx || deltax < -boundx)
        {
            if(transform.position.x < lookAt.position.x)
            {
                delta.x = deltax - boundx;
            }
            else
            {
                delta.x = deltax + boundx;
            }
        }

        float deltay = lookAt.position.y - transform.position.y;
        if (deltay > boundy || deltay < -boundy)
        {
            if (transform.position.y < lookAt.position.y)
            {
                delta.y = deltay - boundy;
            }
            else
            {
                delta.y = deltay + boundy;
            }
        }
        transform.position += new Vector3(delta.x, delta.y, 0);
    }
}

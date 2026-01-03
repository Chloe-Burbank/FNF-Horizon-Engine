using UnityEngine;

[ExecuteInEditMode]
public class ParallaxLayer : MonoBehaviour
{
    public float parallaxFactorX;
    public float parallaxFactorY;

    public void Move(float delta)
    {
        Vector3 newPos = transform.localPosition;
        newPos.x -= delta * parallaxFactorX;
         newPos.x -= delta * parallaxFactorY;

        transform.localPosition = newPos;
    }

}

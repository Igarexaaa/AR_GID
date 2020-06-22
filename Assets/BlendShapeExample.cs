using UnityEngine;
using System.Collections;

public class BlendShapeExample : MonoBehaviour
{
    [SerializeField]
    BlendShapes_test blend_open_mouse;
    [SerializeField]
    BlendShapes_test blend_open_eye_1;
    [SerializeField]
    BlendShapes_test blend_open_eye_2;

    SkinnedMeshRenderer skinnedMeshRenderer;
    Mesh skinnedMesh;

    void Start()
    {
        skinnedMeshRenderer = GetComponent<SkinnedMeshRenderer>();
        skinnedMesh = GetComponent<SkinnedMeshRenderer>().sharedMesh;
        blend_open_mouse = new BlendShapes_test(skinnedMeshRenderer, skinnedMesh); 
    }

    void FixedUpdate()
    {
        blend_open_mouse.BlendShapesRand();
        blend_open_eye_1.BlendShapesRand();
        blend_open_eye_2.BlendShapesRand();
    }
}

[System.Serializable]
public class BlendShapes_test
{
    SkinnedMeshRenderer skinnedMeshRenderer;
    Mesh skinnedMesh;
    public int numberBlend = 0;
    float startBlendEqual = 0f;
    public int maxBlendValue = 100;
    public int minSpeed;
    public int maxSpeed;
    float blendSpeed = 5f;
    bool blendOneFinished = false;
    public bool enableBlendTesting = false;

    public BlendShapes_test(SkinnedMeshRenderer SMR, Mesh SM)
    {
        skinnedMeshRenderer = SMR;
        skinnedMesh = SM;
        Debug.Log("Create Blend Test!");
    }

    public void BlendShapesRand()
    {
        if (enableBlendTesting)
        {
            blendSpeed = Random.Range(minSpeed, maxSpeed);
            if (startBlendEqual < maxBlendValue && !blendOneFinished)
            {
               Debug.Log("++");
                skinnedMeshRenderer.SetBlendShapeWeight(numberBlend, startBlendEqual);
                startBlendEqual += blendSpeed;
            }
            else if (startBlendEqual >= maxBlendValue)
            {
               Debug.Log("stop ++");
                blendOneFinished = true;
            }

            if (startBlendEqual > 5 && blendOneFinished)
            {
               Debug.Log("--");
                skinnedMeshRenderer.SetBlendShapeWeight(numberBlend, startBlendEqual);
                startBlendEqual -= blendSpeed;
            }
            else if (startBlendEqual <= 5)
            {
                blendOneFinished = false;
            }
        }
    }
}

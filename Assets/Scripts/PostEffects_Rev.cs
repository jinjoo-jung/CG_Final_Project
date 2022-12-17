using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class PostEffects_Rev : MonoBehaviour
{

    Shader myShader;
    Material myMaterial;
    // Start is called before the first frame update
    void Start()
    {
        myShader = Shader.Find("My/PostEffects/Rev");
        myMaterial = new Material(myShader);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Graphics.Blit(source, destination, myMaterial, 0);
    }
    private void OnDisable()
    {
        //ī�޶� ��Ȱ��ȭ�� ȣ��Ǵ� �̺�Ʈ��
        if (myMaterial) 
        { DestroyImmediate(myMaterial); 
        
        }
        

    }
}

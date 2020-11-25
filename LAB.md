### Unity + Arduino
The first problem to be solved is to establish communication between Arduino and unity.

[This is tutorial link](https://www.youtube.com/watch?v=of_oLAvWfSI)

👆According to the tutorial in this link step by step, I successfully built a link between Arduino and unity. But in the process, I encountered several problems:

>  1. If want to <import System.IO.Ports>, we need to adjust API level to net 2.0.
>
>  2. The serial port monitor needs to be turned on and off every time then the signal can be transmitted successfully to unity. 👈❓

![img](https://github.com/lalisa777/xiaojielin/blob/master/Advanced%20Physical%20Computing/file/IMG_5524.gif)  

### Unity Setup
Setup the virtual world -- UI reference
pinterest

#### Scene1 -- FEAR

The emotion of fear is expressed in two contrasting colors, which are red and green. Red makes people feel dangerous. It is outstanding against the contrast of green. The background uses repeated cubes to create a sense of loss, and some irregular and angular geometric figures are in the front to give people a sense of danger.


The generation of fear is always accompanied by unknown and unfamiliar. Therefore, in the flow, the feedback after the interaction must give the player a sense of unknown. The changes between the screens cannot be continuous, which provides an uncomfortable feeling to players. In this scene, the player can cause intense deformation of geometric objects by clicking. The speed of deformation will increase as the number of clicks increases until the object explodes.

 1. Modeling -- blender (An entire box or two walls❓)
 ![img](https://github.com/lalisa777/xiaojielin/blob/master/Advanced%20Physical%20Computing/file/A12EF4B7-692C-42E4-9854-8741F5640240.png)  
 ![img](https://github.com/lalisa777/xiaojielin/blob/master/Advanced%20Physical%20Computing/file/79DD1AE4-42E3-4875-9D92-E1351A8CD792.png)  

 2. Lighting effects and camera angles
 ![img](https://github.com/lalisa777/xiaojielin/blob/master/Advanced%20Physical%20Computing/file/5C7581E9-DA4E-4278-8712-AE0DB01ACBA2.png)   
 ![img](https://github.com/lalisa777/xiaojielin/blob/master/Advanced%20Physical%20Computing/file/A32D99E4-3002-433D-A3B7-5DD61CBFB575.png)  

 3. Box floating

```html
        float radian = 0; 
	float perRadian = 0.03f; 
	float radius = 0.2f; 
	Vector3 oldPos; 
    
    void Start()
    {
        oldPos = transform.position;
    }

    void Update()
    {
        radian += perRadian; 
	float dy = Mathf.Cos(radian) * radius; 
	transform.position = oldPos + new Vector3 (0, dy, 0);

    }
```
*👆 My track: First, record the position of the object, and then change the position through update. How to change it? Change the Y coordinate of an object with a cosine function.*

 4. Material —— Shader
 
 Want to achieve a drastic deformation effect
 Ordinary textures are difficult to achieve the effect I want, you can try to use unity shader graph
 [This is tutorial link](https://www.youtube.com/watch?v=kr_tdKCT2Xs)
 
 5. Interaction
licking will accelerate the interactive effect of the deformation, then make the variable in the shader graph public, and then control that variable through the effect of the click.
 [This is tutorial link](https://www.youtube.com/watch?v=EANtTI6BCxk)
 
 
 6. color and effect
 Finally adjusted the overall lighting and colors to highlight the atmosphere

#### Scene2 -- JOY

For the emotion of joy, orange and green are used in the choice of colors, which represent the sunlight and life. The shape is spherical because this kind of curve means softness and relaxation, which gives people a feeling of fullness and strength in emotion.

For the emotion of joy, the entire interaction flow describes that the feeling of joy is relaxed and pleasant, and joy is hugely influential. Therefore, the overall speed of interaction is brisk. Clicking on the surrounding balls can trigger the balls to fly quickly, giving the players instant and intense feedback and creating a positive emotion. At the same time, the small flying ball may hit the big ball, causing the big ball to spin quickly, which is to express that everyone is easily infected by happy emotion.

1. Source of inspiration: what kind of elements can express happiness

 ![img](https://i.pinimg.com/564x/a1/72/f9/a172f9e1df0135e6529b77824a4881ef.jpg)  
 ![img](https://i.pinimg.com/564x/25/73/0a/25730a6b82d473fa9d8bc8bff9375c0d.jpg)  
 ![img](https://i.pinimg.com/564x/62/68/59/62685920e703739d8bb9fe3f8be47ba5.jpg)  
 ![img](https://i.pinimg.com/474x/25/47/e5/2547e581fe50abe052201dbf22810a91.jpg)  
 ![img](https://i.pinimg.com/474x/e4/7a/7a/e47a7a51b1df8cab7f837324a4bde0cd.jpg)  
 ![img](https://i.pinimg.com/474x/d3/c8/ba/d3c8ba67fbad30d527523a2d10a1bba6.jpg)  
  keywords : full, round, soft, clear
  
  2. Jumping balls
  
  Use a small jumping ball to represent the factor of happiness. When jumping on the screen, it is best to use a soft material, which will deform when it is squeezed by collision.
  
  ❓ How to make the balls fall all in an instant?
I can add a baffle above, if you click it, the baffle disappears and the ball will fall
![img](https://github.com/lalisa777/xiaojielin/blob/master/Advanced%20Physical%20Computing/file/1511606345243_.pic.jpg)  
![img](https://github.com/lalisa777/xiaojielin/blob/master/Advanced%20Physical%20Computing/file/WeChata05953b7404f8be221b79204cbd33fc2.png)  

❗️ Doing so will greatly slow down the running speed of the game, which may be because a lot of models need to be pre-loaded at the beginning of the game (especially these models require a lot of vector operations in order to achieve soft materials)

 👆how to solve this problem？？

✨ prefab!!

❓ main character？

![img](https://github.com/lalisa777/xiaojielin/blob/master/Advanced%20Physical%20Computing/file/WeChat34b0fe9429554099896acff93eaec210.png)  

I want a key word here: Happiness is infectious
So put a main character in the middle of the scene, this main character will be affected by the falling ball


❓ soft material
Still use shader graph to complete

3. color

✨Is there a need for a color change? After the interaction, the color flashes, which is a happy effect？



#### Scene3 -- SADNESS

Blue is selected for the emotion of sadness. In the scene, there are various, but regular straight lines to create a sense of balance, stability, and continuity.

Sadness and joy are opposite interaction flows. The overall rhythm is slow. The way of interaction is slower dragging instead of fast clicking. Dragging the lines makes the lines rotate slowly, showing different light and shadow effects.

1.Source of inspiration:

![img](https://i.pinimg.com/474x/32/0c/c3/320cc3e498a8728cc1059911c4509dff.jpg)  
 ![img](https://i.pinimg.com/474x/8b/c1/5d/8bc15d5fdda84b2388248a9620c1360d.jpg)  
 ![img](https://i.pinimg.com/474x/16/69/8e/16698e06235ac7d250d5e67d1b314403.jpg)  
 keywords: mystery, lost, hopeless
 
2. 3D modelling in blender

![img](https://github.com/lalisa777/xiaojielin/blob/master/Advanced%20Physical%20Computing/file/WeChata924818340cda688e87de2c6d6aec4ce.png)  

3.  color and effect

![img](https://github.com/lalisa777/xiaojielin/blob/master/Advanced%20Physical%20Computing/file/WeChat7dbda0aead7eff1edd601825f608092c.png)  

 
 This piece is based on Donald Arthur Norman’s theory – ‘emotional design’ to create emotions in an virtual environment. Analyze and study the three levels of visceral, behavioral and reflectional respectively, and try to involve players’ internal experience into the design of scenes and interactions in scenes in order to stimulate and evoke players’ emotional experience. 
 
 4. interaction
 
 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragtorotate : MonoBehaviour
{
    public float speed = 100f;
    bool dragging = false;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnMouseDrag()
    {
        dragging = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonUp(0))
        {
            dragging = false;
        }
    }

    void FixedUpdate()
    {
        if(dragging)
        {
            float x = Input.GetAxis("Mouse X") * speed * Time.fixedDeltaTime;
            float y = Input.GetAxis("Mouse Y") * speed * Time.fixedDeltaTime;
            print(x);

            rb.AddTorque(Vector3.down * x);
            rb.AddTorque(Vector3.right * y);
        }
    }
}


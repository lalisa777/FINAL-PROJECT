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

1. Source of inspiration: what kind of elements can express happiness

 ![img](https://i.pinimg.com/564x/a1/72/f9/a172f9e1df0135e6529b77824a4881ef.jpg)  
 ![img](https://i.pinimg.com/564x/25/73/0a/25730a6b82d473fa9d8bc8bff9375c0d.jpg)  
 ![img](https://i.pinimg.com/564x/62/68/59/62685920e703739d8bb9fe3f8be47ba5.jpg)  
 ![img](https://i.pinimg.com/474x/25/47/e5/2547e581fe50abe052201dbf22810a91.jpg)  
 ![img](https://i.pinimg.com/474x/e4/7a/7a/e47a7a51b1df8cab7f837324a4bde0cd.jpg)  
 ![img](https://i.pinimg.com/474x/d3/c8/ba/d3c8ba67fbad30d527523a2d10a1bba6.jpg)  

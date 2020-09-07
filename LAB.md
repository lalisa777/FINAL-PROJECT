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



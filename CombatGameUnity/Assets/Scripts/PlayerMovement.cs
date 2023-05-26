using OpenCover.Framework.Model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


/* the scritps goal;
 * player movement and sprinting 
 * gravity effects and colions without rigidbody
 * player dashining in direation of movement 
 */

public class PlayerMovement : MonoBehaviour
{
    
    private Vector3 Vel;
    private Vector3 Pos;

   //Camara Properties
    public float sensX;
    public float sensY;
    public Transform orientation;
    float xRotation;
    float yRotation;
   //Movement Properties
    public float speedX = 10.0f;
    public float speedY = 10.0f;
    public float SprintFactor = 5;
    public float dashFactor = 2;

    // Start is called before the first frame update
    private void Start()
    {


        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        
        Vector3 Vel = new Vector3(0.0f, 0.0f, 0.0f);
        transform.position = Pos = new Vector3 (0.0f, 1.0f, 0.0f);

        
}

    // Update is called once per frame
    private void Update()
    {
        // get mouse input 
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

        yRotation += mouseX;
        xRotation -= mouseY;

        // rotate cam and orientaion
        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        orientation.rotation = Quaternion.Euler(0, yRotation, 0);



        //Player Gravity

        //player Jump




        //PlayerMovement 

            

        
            float translationX = Input.GetAxis("Vertical") * speedX;
            float translationY = Input.GetAxis("Horizontal") * speedY;

            translationX *= Time.deltaTime;
            translationY *= Time.deltaTime;

            transform.Translate(0, 0, translationX);
            transform.Translate(translationY, 0, 0);
        



        //DashMovement. inpovments, make it so then its not an instent tel to dash location
                        //inpovments,Make is so then while sprinting dash is same while walking 

        

        if (Input.GetKeyDown(KeyCode.Space & KeyCode.W))
        {
            float DashX = Input.GetAxis("Vertical");
            DashX *= speedX * dashFactor;
            transform.Translate(0, 0, DashX);
        }

        if (Input.GetKeyDown(KeyCode.Space & KeyCode.D))
        {
            float DashY = Input.GetAxis("Horizontal");
            DashY *= speedY * dashFactor;
            transform.Translate(DashY, 0, 0);
        }
        


    }
}

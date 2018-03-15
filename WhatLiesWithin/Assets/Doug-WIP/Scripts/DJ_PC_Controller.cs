using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DJ_PC_Controller : MonoBehaviour {

    // [Tooltip ("Speed of the character")]
    // public float fl_MoveSpeed;
    //  [Tooltip ("Rotation speed of the camera")]
    // public float fl_CameraSpeed;
    //public float fl_jump;

    [Tooltip("Rotation speed of the camera")]
    public float fl_mouse_rotation_rate;
    [Tooltip("Speed of the character")]
    public float fl_speed;
    [Tooltip("Strength of Jump")]
    public float fl_jump_force;
    [Tooltip("Length of time the phone light is on for")]
    public float fl_timer;
    [Tooltip("How long the phone is forced off for")]
    public float fl_cooldown;


    public GameObject go_LightPhone;
    public Canvas ca_messages;
    public Canvas ca_light_phone;
    public Camera ca_Camera;
    
    

    private float fl_cooldowntime;
    private bool bl_onCooldown;
    private float fl_starttime;
    private AudioSource as_click;
    private bool bl_Light;
    private bool bl_Phone;
    private bool bl_Has_phone;
    private bool bl_Jumped;
    private Rigidbody rb_pc;



    // Use this for initialization
    void Start () {
        #region Phone Start
        as_click = GetComponent<AudioSource>();
        fl_starttime = fl_timer;
        fl_cooldowntime = fl_cooldown;
        #endregion

        rb_pc = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate () {


        MovePC();
        CheckGrounded();

        #region OLD PC Movement
        /*
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * fl_MoveSpeed;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * fl_MoveSpeed;

        var pitch = Input.GetAxis("Mouse X") * Time.deltaTime * (fl_CameraSpeed*2);
        var yaw = Input.GetAxis("Mouse Y") * Time.deltaTime * fl_CameraSpeed;

        transform.Rotate(0, fl_mouse_rotation_rate * Time.deltaTime * Input.GetAxis("Mouse X"), 0);



        transform.Rotate(0, pitch, 0);
        transform.Translate(x, 0, z);
        ca_Camera.transform.Rotate(yaw, 0,0);

        if ((Input.GetKeyDown(KeyCode.Space)) && (bl_Jumped == false))
        {
            rb_pc.AddForce(Vector3.up * fl_jump);
            
        } */



        #endregion

        #region Phone
        bl_Has_phone = DJ_GameManager.bl_HasPhone;
        if (bl_Has_phone)
        {

            #region Message Phone
            if ((Input.GetKeyDown(KeyCode.P)) && (!bl_Phone) && (!bl_Light))
            {
                bl_Phone = true;

                ca_messages.enabled = true;
                as_click.Play();

            }
            else if ((Input.GetKeyDown(KeyCode.P)) && (bl_Phone))
            {
                ca_messages.enabled = false;
                bl_Phone = false;
                as_click.Play();
            }
            #endregion

            #region Light Phone
            if ((Input.GetKeyDown(KeyCode.L)) && (!bl_Light) && (!bl_Phone) && (!bl_onCooldown))
            {

                go_LightPhone.SetActive(true);
                ca_light_phone.enabled = true;
                bl_Light = true;
                as_click.Play();


            }
            else if ((Input.GetKeyDown(KeyCode.L)) && (bl_Light))
            {

                go_LightPhone.SetActive(false);
                ca_light_phone.enabled = false;
                bl_Light = false;
                as_click.Play();
                bl_onCooldown = true;
            }

            if ((bl_Light == true) && (bl_onCooldown == false))
            {
                fl_timer -= Time.deltaTime;
                if (fl_timer <= 0)
                {
                    bl_Light = false;
                    go_LightPhone.SetActive(false);
                    ca_light_phone.enabled = false;
                    bl_onCooldown = true;
                }
            }
            if (bl_onCooldown == true)
            {
                fl_cooldown -= Time.deltaTime;
                if (fl_cooldown <= 0)
                {
                    fl_timer = fl_starttime;
                    bl_onCooldown = false;
                    fl_cooldown = fl_cooldowntime;
                }
            }
            #endregion
        }
        #endregion

    }

    private void MovePC()
    {
        // Mouse Rotate
        transform.Rotate(0, fl_mouse_rotation_rate * Time.deltaTime * Input.GetAxis("Mouse X"), 0);

        //calculate the velocity vector
        Vector3 _v3_move_direction = transform.position + (fl_speed * Time.deltaTime * transform.TransformDirection(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"))));

        // Apply movement vector to the rigid body
        rb_pc.MovePosition(_v3_move_direction);

        // Jump if Grounded
        if (bl_Jumped == false)
        {
            if (Input.GetKeyDown(KeyCode.Space))
                rb_pc.AddForce(Vector3.up * fl_jump_force);
        }

        


    }

    private void CheckGrounded()
    {
        RaycastHit hitInfo;

        if (Physics.SphereCast(transform.position, 0.4F, Vector3.down, out hitInfo, 0.65F))
            bl_Jumped = false;
        else
            bl_Jumped = true;
    } 
}

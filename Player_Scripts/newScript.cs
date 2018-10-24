using UnityEngine;

public class newScript : MonoBehaviour {
    public Rigidbody a;
    public Rigidbody bullet;
    public float forwardForce =20;
    public float sideForce = 10;

	// Use this for initialization
	void Start () {
        Debug.Log("Player is ready"); ;
        a.useGravity = true;
        //a.AddForce(0, 0, forwardForce * Time.deltaTime);
         a.AddForce(0, 0,444);
    }
	
	// Update is called once per frame
    //FixedUpdate is waaay better- it allows us to work with physics better!
	void FixedUpdate () {



        //adds a forwardforce with the z direction beng egqual to that var
        //a.AddForce(0,0,forwardForce*3*Time.deltaTime);

        //   a.AddForce(0, 0, 1000 * Time.deltaTime);

        if (Input.GetKey("w")||Input.GetKey("up"))
        {
            a.AddForce( 0, 0, sideForce* Time.deltaTime, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a") || Input.GetKey("left"))
        {
            a.AddForce(-(sideForce * Time.deltaTime), 0, 0,ForceMode.VelocityChange);
        }

        if (Input.GetKey("s") || Input.GetKey("down"))
        {
            a.AddForce(0, 0, -(sideForce * Time.deltaTime), ForceMode.VelocityChange);
        }
       
        if (Input.GetKey("d") || Input.GetKey("right")) {
            a.AddForce(sideForce*Time.deltaTime,0, 0,ForceMode.VelocityChange);
        }

        if (Input.GetKey("z") || Input.GetKey("m"))
        {
            a.AddForce(0, sideForce * Time.deltaTime, 0, ForceMode.VelocityChange);
        }

        //falling below ground so end game
        if (a.position.y < -1) {

            FindObjectOfType<score>().fallen = true;
            FindObjectOfType<Manager>().endGame();
       }
	}
}

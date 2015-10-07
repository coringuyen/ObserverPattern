using UnityEngine;

static public class Events
{
    static public void printStuff()
    {
        Debug.Log("printing stuff");
    }
}
//{
//    Publisher pub;

//    void Start()
//    {
//        pub = GetComponent<Publisher>();
//    }

//	void Update()
//    {
//        if(Input.GetKeyDown(KeyCode.A))
//        {
//            pub.publisher("Key A been press");
//        }
//    }

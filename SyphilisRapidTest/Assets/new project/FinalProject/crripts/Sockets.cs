using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using UnityEngine;
using System.Text.RegularExpressions;
using System.Linq;


public class Sockets : MonoBehaviour
{



    TcpListener server;
    TcpClient client;
    IEnumerator doClient = null;





    public string ipAddress = "127.0.0.1";
    public int port = 54010;

    void Client_Connected(IAsyncResult res)
    {
        client = server.EndAcceptTcpClient(res);
    }


    void redray()
    {
        Debug.DrawRay(gameObject.transform.position, gameObject.transform.forward * 10, Color.white);

    }

    void Update()
    {
        redray();

        if (client != null && doClient == null)
        {
            doClient = DoClient();
            StartCoroutine(doClient);
        }

       
        if(hitetd != null)
        {
            hitetd.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z - 0.8f);

        }


    }


    float f1, f2, f3;

    string[] flist;


    Vector3 MoveVector = new Vector3();


    public GameObject hitetd;

    public string recivedmsg;


    public string lastFragment;
    public float Yinput;

   IEnumerator DoClient()
    {
        int bytesReceived = 0;
        byte[] buf = new byte[49152];
        var stream = client.GetStream();



        do
        {
            bytesReceived = stream.Read(buf, 0, buf.Length);
            if (bytesReceived > 0)
            {
                string msg = Encoding.ASCII.GetString(buf, 0, bytesReceived);

                //   Debug.Log(msg);



                recivedmsg = msg;


                 
                
                 lastFragment = msg.Split('>').Last();

                if(lastFragment.Contains(","))
                {

                    Yinput = 0;
                }
                else
                {
                    

                    float.TryParse(lastFragment, out Yinput);

                }

                if (msg.Contains("*"))
                {

                  
                    Ray ray= new Ray(gameObject.transform.position, gameObject.transform.forward *10);
                   
                    RaycastHit hit;

                    if(Physics.Raycast(ray, out hit))
                    {

                        Debug.DrawRay(ray.origin, hit.transform.position, Color.red);

                        if (hit.transform.gameObject.tag == "grab1")
                        {
                            hitetd = hit.transform.gameObject;
                            Debug.Log("hittttt");
                        }


                    }

                }

                for (int i = 0; i < msg.Length; i++)
                {
                    if (msg[i] == '(')
                    {
                        msg.Remove(i);
                    }

                }



                flist = Regex.Split(msg, ",");





                foreach (string s in flist)
                {

                    Debug.Log(s);
                }


                float mvx, mvz;

                float.TryParse(flist[0], out mvx);

                float.TryParse(flist[2], out mvz);



                if (mvz != 0 && mvx != 0)
                    gameObject.transform.Translate(new Vector3(mvx, 0, -mvz) /10);
                


                //if (msg == "QUOTE")
                //{
                //    byte[] quoteOut = Encoding.ASCII.GetBytes("newbismieri stringi");
                //    stream.Write(quoteOut, 0, quoteOut.Length);
                //}
                //if (msg[0] == 'a')
                //{
                //    Debug.Log("sdsdsfdscdc");
                //}

            }

            yield return null;
        }
        while (bytesReceived > 0);

        // Reset everything to defaults
        doClient = null;
        client.Close();
        client = null;

        // Accept a new client
        server.BeginAcceptTcpClient(Client_Connected, null);
    }

    void Start()
    {


        IPAddress ip = IPAddress.Parse(ipAddress);
        server = new TcpListener(IPAddress.Any, port);
        server.Start();

        server.BeginAcceptTcpClient(Client_Connected, null);
    }


    // >>***


    private static Vector3 cursorWorldPosOnNCP
    {
        get
        {
            return Camera.main.ScreenToWorldPoint(
                new Vector3(Input.mousePosition.x,
                Input.mousePosition.y,
                Camera.main.nearClipPlane + 1));
        }
    }

    private static Vector3 cameraToCursor
    {
        get
        {
            return cursorWorldPosOnNCP - Camera.main.transform.position;
        }
    }

    private Vector3 cursorOnTransform
    {
        get
        {
            Vector3 camToTrans = transform.position - Camera.main.transform.position;
            return Camera.main.transform.position +
                cameraToCursor *
                (Vector3.Dot(Camera.main.transform.forward, camToTrans) / Vector3.Dot(Camera.main.transform.forward, cameraToCursor));
        }
    }


    // >>***
}

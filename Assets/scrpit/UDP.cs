using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

public class UDP : MonoBehaviour {


    static UdpClient udp;
    IPEndPoint remoteEP = null;
    int i = 0;
    public string text = 0.ToString();
    public string percent = 50.ToString();
    public string num = 0.ToString();




    [SerializeField]
    private float interval = 1.0f;
    [SerializeField]
    private float tmpTime = 0;
    // Use this for initialization
    void Start () {
        int LOCA_LPORT = 50007;

        udp = new UdpClient(LOCA_LPORT);
        udp.Client.ReceiveTimeout = 10000;

    }
	
	// Update is called once per frame
	void Update ()
    {
        tmpTime += Time.deltaTime;
        if (tmpTime >= interval)
        {
            IPEndPoint remoteEP = null;
            byte[] data = udp.Receive(ref remoteEP);
            /*if (4 < float.Parse(Encoding.UTF8.GetString(data)) &&  float.Parse(Encoding.UTF8.GetString(data)) < 100)*/
            var inf = (Encoding.UTF8.GetString(data));
            string[] python = inf.Split(',');

            Debug.Log(inf);
            /*
            if (4 < float.Parse(Encoding.UTF8.GetString(data)) &&  float.Parse(Encoding.UTF8.GetString(data)) < 100)
            {
                percent = Encoding.UTF8.GetString(data);

            }else if (  float.Parse(Encoding.UTF8.GetString(data)) < 4)
            {
                text = Encoding.UTF8.GetString(data);
            }
            else
            {
                num = Encoding.UTF8.GetString(data);
            };
            */

            /* Debug.Log(text);*/

            percent = python[1];

            text = python[0];

            num = python[2];

            tmpTime = 0;
            if(text == 3.ToString())
            {
                udp.Close();
            }

        }
    }
}

/*       
       while (true)
        {
            IPEndPoint remoteEP = null;
            byte[] data = udp.Receive(ref remoteEP);
            string text = Encoding.UTF8.GetString(data);
            Debug.Log(text);
            Thread.Sleep(1000);
        }
        */

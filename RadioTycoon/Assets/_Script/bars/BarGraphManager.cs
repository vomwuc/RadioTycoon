using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class BarGraphManager : MonoBehaviour
{

    public GameObject linerenderer;
    public GameObject pointer;

    public GameObject HolderPrefb;

    public GameObject holder;

    public Material mat;

    public Text topValue;

    public List<GraphData> graphData = new List<GraphData>();

    private GraphData gd;
    private float highestValue;

    void Start()
    {
        UpdateData();
    }

    public void UpdateData()
    {

        // Instantiate an empty gameObject to hold all line renderers
        holder = Instantiate(HolderPrefb, Vector3.zero, Quaternion.identity) as GameObject;
        holder.name = "h2";

        graphData.Clear();

        // Lenght of data to be shown in graph
        int length = Random.Range(5, 12);
        // Inserting data to the list
        for (int i = 0; i < length; i++)
        {
            gd = new GraphData();

            gd.income = Random.Range(10.0f, 100.0f);

            if (gd.income > highestValue)
                highestValue = gd.income;

            graphData.Add(gd);
        }

        // Adjusting value to fit in graph
        for (int i = 0; i < graphData.Count; i++)
        {
            // since Y axis is from 0 to 3 we are dividing the income with the highest income
            // so that we get a value less than or equals to 1 and than we can multiply that
            // number with Y axis range to fit in graph. 
            // e.g. income = 90, highest = 90 so 90/90 = 1 and than 1*3 = 3 so for 90, Y = 3
            graphData[i].income = (graphData[i].income / highestValue) * 3;
        }

        topValue.text = Mathf.FloorToInt(highestValue).ToString();

        StartCoroutine("BarGraph", graphData);
    }

    IEnumerator BarGraph(List<GraphData> gd)
    {

        float gap = 1;

        // X axis starts from 0 to 4 so according to my logic i have to check if no. of data
        // is > 4 than we should divide the lenght of x axis with the data count, this will
        // give us the gap between bars that we need to keep.

        if (gd.Count > 4)
        {
            gap = 4.0f / gd.Count;
        }

        float xIncrement = gap;
        int dataCount = 0;
        Vector3 startpoint = Vector3.zero;

        while (dataCount < gd.Count)
        {

            Vector3 endpoint = new Vector3(xIncrement, gd[dataCount].income, 0.96f);
            startpoint = new Vector3(endpoint.x, 0, 0.96f);
            // pointer is an empty gameObject, i made a prefab of it and attach it in the inspector
            GameObject p = Instantiate(pointer, new Vector3(startpoint.x, startpoint.y, 0.97f), Quaternion.identity) as GameObject;
            p.transform.parent = holder.transform;

            // linerenderer is an empty gameObject with Line Renderer Component Attach to it, 
            // i made a prefab of it and attach it in the inspector
            GameObject lineObj = Instantiate(linerenderer, transform.position, Quaternion.identity) as GameObject;
            lineObj.transform.parent = holder.transform;
            lineObj.name = dataCount.ToString();

            LineRenderer lineRenderer = lineObj.GetComponent<LineRenderer>();

            lineRenderer.material = mat;
            lineRenderer.SetWidth(0.15F, 0.15F);
            lineRenderer.SetVertexCount(2);

            while (p.transform.position.y < endpoint.y)
            {
                p.transform.Translate(Vector3.up * Time.deltaTime * 8, Space.World);

                lineRenderer.SetPosition(0, startpoint);
                lineRenderer.SetPosition(1, p.transform.position);

                yield return null;
            }

            lineRenderer.SetPosition(0, startpoint);
            lineRenderer.SetPosition(1, endpoint);


            p.transform.position = endpoint;

            startpoint = endpoint;
            dataCount++;
            xIncrement += gap;

            yield return null;

        }
    }



    public class GraphData
    {
        public float income;
    }
}
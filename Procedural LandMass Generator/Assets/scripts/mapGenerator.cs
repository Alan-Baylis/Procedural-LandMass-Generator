using UnityEngine;

public class mapGenerator : MonoBehaviour {
    public int mapHeight;
    public int mapWidth;
    public float scale;
    public bool autoUpdate;


    public void GenerateMap()
    {
        float[,] noiseMap = noise.GenerateNoiseMap(mapWidth, mapHeight, scale);

        mapDisplay display = FindObjectOfType<mapDisplay>();
        display.DrawNoiseMap(noiseMap);
    }
	
}

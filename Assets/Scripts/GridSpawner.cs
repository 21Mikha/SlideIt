using UnityEngine;
using TMPro;

public class GridSpawner : MonoBehaviour
{
    [Header("Prefab and Settings")]
    public GameObject cellPrefab; // Prefab to instantiate
    public Vector2 gridSize = new Vector2(4, 5); // Width x Height

    [Header("TextMeshPro Settings")]
    public TMP_FontAsset font; // Assign a font asset in the Inspector

    private void Start()
    {
        SpawnGrid();
    }

    private void SpawnGrid()
    {
        for (int x = 0; x < gridSize.x; x++)
        {
            for (int y = 0; y < gridSize.y; y++)
            {
                // Instantiate the cell prefab
                Vector3 position = new Vector3(x, -y, 0); // Adjust for layout
                GameObject cell = Instantiate(cellPrefab, position, Quaternion.identity, transform);

                // Add TextMeshPro text in the center of the cell
                GameObject textObject = new GameObject("CellIndexText");
                textObject.transform.SetParent(cell.transform);
                textObject.transform.localPosition = Vector3.zero;

                // Display row-wise grid indices {x, y}
                TMP_Text textMesh = textObject.AddComponent<TextMeshPro>();
                textMesh.text = "x:"+x+","+"y:"+y;
                textMesh.fontSize = 2;
                textMesh.font = font;
                textMesh.alignment = TextAlignmentOptions.Center;
            }
        }
    }

}

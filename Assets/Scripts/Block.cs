using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum BlockType
{
    Block1x1,
    Block2x1,
    Block1x2,
    Block2x2
}
public abstract class Block : MonoBehaviour
{
    private int width;
    private int height;
    private Vector2 position;
    private BlockType type;


    public abstract void initialize();

    public void SetPosition(Vector2 position)
    { this.position = position; }
    public Vector2 GetPosition(Vector2 position)
    { return position; }
    public void SetHeight(int height) { this.height = height; }
    public void SetWidth(int width) { this.width = width; }
    public int GetHeight() { return height; }
    public int GetWidth() { return width; }

    public void SetType(BlockType type) => this.type = type;
    public BlockType GetType() { return type; }
}

using UnityEngine;

public class Block1x1 : Block
{
    private void Start()
    {
        initialize();
    }

    public override void initialize()
    {
        SetWidth(1);
        SetHeight(1);
        SetType(BlockType.Block1x1);
        SetPosition(new Vector2(0,0));
    }
}

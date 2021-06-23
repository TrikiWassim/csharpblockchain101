
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Blockchain : IEnumerable<IBlock>
{
    //private List<IBlock> _items=new List<IBlock>() ;
    public byte[] Difficulty { get; }
    public Blockchain(byte[] difficulty, IBlock genesis)
    {
        Difficulty = difficulty;
        genesis.Hash = genesis.MineHash(difficulty);
        Blocks.Add(genesis);
    }


    public List<IBlock> Blocks { get; set; }
    public int Count => Blocks.Count;
    public IBlock this[int index]
    {
        get => Blocks[index];
        set => Blocks[index] = value;
    }

    public void Add(IBlock block)
    {

        if (Blocks.LastOrDefault() != null)
        {
            block.PrevHash = Blocks.LastOrDefault().Hash;
            
        }
        block.Hash=block.MineHash(Difficulty);
        Blocks.Add(block);
    }

    public IEnumerator<IBlock> GetEnumerator()
    {
        return Blocks.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return Blocks.GetEnumerator();
    }
}
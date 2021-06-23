using System;

public class Block : IBlock
{
    public byte[] Data {get;}

    public byte[] Hash { get; set ; }
    public byte[] PrevHash { get; set ; }

    public DateTime TimeStamp {get;}

    public byte[] MineHash(byte[] difficulty)
    {
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        return $"{BitConverter.ToString(Hash).Replace(".","")} :\n {BitConverter.ToString(PrevHash).Replace(".","")} :\n {TimeStamp}";
    }
}
using System;

public interface IBlock{
    byte[] Data {get;}
    byte[] Hash {get;set;}
    public byte[] PrevHash { get; set; }
    public DateTime TimeStamp { get; }

    byte[] MineHash(byte[] difficulty);
}
using Stratis.SmartContracts;
using System;

public class MyContract : SmartContract
{
    public MyContract(ISmartContractState smartContractState)
    : base(smartContractState)
    {
        this.Firstvalue = 5;
        this.SecondValue = 10;
    }

    public Int32 Firstvalue
    {
        get => PersistentState.GetInt32(nameof(Firstvalue));
        private set => PersistentState.SetInt32(nameof(Firstvalue), value);
    }

    private Int32 SecondValue
    {
        get
        {
            return this.PersistentState.GetInt32("SecondValue");
        }
        set
        {
            this.PersistentState.SetInt32("SecondValue", value);
        }
    }
    
    public long GetSum()
    {
        long sum = (Firstvalue + SecondValue);
        return sum;
    }

    public long GetMultiply()
    {
        long mul = (Firstvalue * SecondValue);
        return mul;
    }

    public long GetDivision()
    {
        long div = (SecondValue / Firstvalue);
        return div;
    }
}
using AElf.Sdk.CSharp.State;

namespace AElf.Contracts.MyCharacter
{
    // The state class is access the blockchain state
    public class MyCharacterState : ContractState 
    {
        // A state that holds string value
        public StringState Message { get; set; }
    }
}
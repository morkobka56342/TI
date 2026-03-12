using System.Collections;

namespace TI_LAB_2;

public class StreamCipher
{
    public BitArray RegisterBit { get; private set; }
    public BitArray KeyBit { get; private set; }
    public BitArray PlainText { get; set; }
    public BitArray CipherBit { get; private set; }

    public void ProduceRegister(string parsingString)
    {
        RegisterBit = new BitArray(parsingString.Length);
        for (int i = 0; i < parsingString.Length; i++)
            RegisterBit[i] = parsingString[i] == '1';
    }

    public void ProduceKey(int length)
    {
        KeyBit = new(length);
        for (int i = 0; i < length; i++)
        {
            KeyBit[i] = RegisterBit[0];

            int len = RegisterBit.Length;  

            bool nextValue = RegisterBit[len - 1 - 39]     
                           ^ RegisterBit[len - 1 - 20] 
                           ^ RegisterBit[len - 1 - 18] 
                           ^ RegisterBit[len - 1 - 1]; 
                          

            for (int index = 0; index < RegisterBit.Length - 1; index++)
            {
                RegisterBit[index] = RegisterBit[index + 1];
            }

            RegisterBit[RegisterBit.Length - 1] = nextValue;
        }
    }

    public void Cipher() => CipherBit = KeyBit.Xor(PlainText); 
}

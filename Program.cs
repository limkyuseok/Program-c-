using Program;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 의존 역전 원칙
            // 추상화는 세부 사항에 의존해서는 안되며,
            // 세부 사항이 추상화에 의존할 수 있도록 설계해야 하는 원칙입니다.

            Character character = new Character();

            character.Acquire(0, new Knife());
            character.Acquire(1, new Grenade());

            Console.WriteLine("--Battle Start--");
            Console.WriteLine("[Space] : Swap | [A] : Attack");

            bool running = true;

            while(running)
            {
                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                    switch(keyInfo.Key)
                    {
                        case ConsoleKey.Spacebar:
                            break;
                        case ConsoleKey.A:
                            break;
                    }
                }
            }

            #endregion
        }

    }
}
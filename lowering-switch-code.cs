//using System;
//using System.Diagnostics;
//using System.Reflection;
//using System.Runtime.CompilerServices;
//using System.Security;
//using System.Security.Permissions;
//using Microsoft.CodeAnalysis;


//public class C
//{
//    public void M()
//    {
//        string[] array = new string[3];
//        array[0] = "shafi";
//        array[1] = "houd";
//        array[2] = "trumboo";
//        Random random = new Random();
//        string text = array[random.Next(0, 2)];
//        uint num = PrivateImplementationDetails.ComputeStringHash(text);
//        if (num <= 2981201675u)
//        {
//            if (num <= 1343205275)
//            {
//                if (num != 465062686)
//                {
//                    if (num != 950963275)
//                    {
//                        if (num == 1343205275 && text == "shafi1")
//                        {
//                            Console.WriteLine(string.Concat("Name was ", text));
//                        }
//                    }
//                    else if (text == "trumboo")
//                    {
//                        Console.WriteLine(string.Concat("Name was ", text));
//                    }
//                }
//                else if (text == "houd12")
//                {
//                    Console.WriteLine(string.Concat("Name was ", text));
//                }
//            }
//            else if (num != 1359982894)
//            {
//                if (num != 2751664057u)
//                {
//                    if (num == 2981201675u && text == "shafi12")
//                    {
//                        Console.WriteLine(string.Concat("Name was ", text));
//                    }
//                }
//                else if (text == "houd")
//                {
//                    Console.WriteLine(string.Concat("Name was ", text));
//                }
//            }
//            else if (text == "shafi2")
//            {
//                Console.WriteLine(string.Concat("Name was ", text));
//            }
//        }
//        else if (num <= 3100734232u)
//        {
//            if (num != 3016172155u)
//            {
//                if (num != 3032949774u)
//                {
//                    if (num == 3100734232u && text == "houd1")
//                    {
//                        Console.WriteLine(string.Concat("Name was ", text));
//                    }
//                }
//                else if (text == "trumboo1")
//                {
//                    Console.WriteLine(string.Concat("Name was ", text));
//                }
//            }
//            else if (text == "trumboo2")
//            {
//                Console.WriteLine(string.Concat("Name was ", text));
//            }
//        }
//        else if (num != 3151067089u)
//        {
//            if (num != 3180887784u)
//            {
//                if (num == 3514698356u && text == "trumboo12")
//                {
//                    Console.WriteLine(string.Concat("Name was ", text));
//                }
//            }
//            else if (text == "shafi")
//            {
//                Console.WriteLine(string.Concat("Name was ", text));
//            }
//        }
//        else if (text == "houd2")
//        {
//            Console.WriteLine(string.Concat("Name was ", text));
//        }
//    }
//}

//[CompilerGenerated]
//internal sealed class PrivateImplementationDetails
//{
//    internal static uint ComputeStringHash(string s)
//{
//    uint num = default(uint);
//    if (s != null)
//    {
//        num = 2166136261u;
//        int num2 = 0;
//        while (num2 < s.Length)
//        {
//            num = (s[num2] ^ num) * 16777619;
//            num2++;
//        }
//    }
//    return num;
//}
//}

//namespace Microsoft.CodeAnalysis
//{
//    [CompilerGenerated]
//    [Embedded]
//    internal sealed class EmbeddedAttribute : Attribute
//    {
//    }
//}

//namespace System.Runtime.CompilerServices
//{
//    [CompilerGenerated]
//    [Microsoft.CodeAnalysis.Embedded]
//    [AttributeUsage(AttributeTargets.Module, AllowMultiple = false, Inherited = false)]
//    internal sealed class RefSafetyRulesAttribute : Attribute
//    {
//        public readonly int Version;

//        public RefSafetyRulesAttribute(int P_0)
//        {
//            Version = P_0;
//        }
//    }
//}

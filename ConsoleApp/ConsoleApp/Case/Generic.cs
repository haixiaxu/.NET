namespace ConsoleApp.Case
{
    /// <summary>
    /// 泛型
    /// </summary>
    public class Generic
    {
        
    }
    /// <summary>
    /// 声明一个泛型类
    /// </summary>
    /// <typeparam name="T"></typeparam>

    public class GenericList<T>
    {
        public void Add(T input) { }
    }

    public class TestGenericList
    {
        private class ExampleClass { }
        static void Main()
        {
            //声明一个int类型列表
            GenericList<int> list1 = new GenericList<int>();
            list1.Add(1);

            //声明一个字符串类型列表
            GenericList<string> list2=new GenericList<string>();
            list2.Add("");

            //声明一个ExampleClass类型列表
            GenericList<ExampleClass> list=new GenericList<ExampleClass>();
            list.Add(new ExampleClass());
        }
    }
}

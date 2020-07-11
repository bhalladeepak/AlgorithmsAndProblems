using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorials
{
    public delegate void TaskCompletedCallBack(string taskResult);
    public class CallBackDelegate
    {
        public void StartNewTask(TaskCompletedCallBack taskCompletedCallBack)
        {
            Console.WriteLine("I have started new Task.");
            if(taskCompletedCallBack != null)
            {
                taskCompletedCallBack("I have completed Task.");
            }

        }
    }

    public class CallBackDelegateTest
    {
        public void Test()
        {
            TaskCompletedCallBack callBack = TestCallBack;
            CallBackDelegate testCallBack = new CallBackDelegate();
            testCallBack.StartNewTask(callBack);
        }

        public void TestCallBack(string result)
        {
            Console.WriteLine(result);
        }
    }

}

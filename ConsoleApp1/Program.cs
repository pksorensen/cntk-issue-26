using CNTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!");



            var deviceDescriptor = DeviceDescriptor.CPUDevice;
            var model = Function.Load("FERPlus.onnx", deviceDescriptor, ModelFormat.ONNX);
            Console.WriteLine("loaded");

            Variable inputVar = model.Arguments.Single();

            NDShape inputShape = inputVar.Shape;
            int imageWidth = inputShape[0];
            int imageHeight = inputShape[1];

            Console.WriteLine($"{imageWidth}x{imageHeight}");

            Console.ReadKey();

        }
    }
}

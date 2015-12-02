using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

namespace MathFloat.Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            var doubleType = typeof(double);
            var math = typeof(Math);
            var methods = math.GetMethods(BindingFlags.Static | BindingFlags.Public);
            methods = (from m in methods
                       where m.ReturnType == doubleType
                       select m)
                       .ToArray();

            var code = new StringBuilder();

            code.AppendLine("//This is Auto-Generated Code");
            code.AppendLine("using System;");
            code.AppendLine("namespace MathFloat");
            code.AppendLine("{");
            code.AppendLine("public static class MathF");
            code.AppendLine("{");

            HashSet<string> UsedSignatures = new HashSet<string>();

            foreach (var method in methods)
            {
                var methodHead = new StringBuilder();
                var methodSignature = new StringBuilder();
                var methodBody = new StringBuilder();

                var name = method.Name;
                methodHead.Append("public static float " + name + "(");
                methodSignature.Append("public static float " + name + "(");

                methodBody.Append("    return (float)Math." + name + "(");


                bool first = true;

                foreach (var param in method.GetParameters())
                {
                    if(param.ParameterType == doubleType)
                    {
                        if (!first)
                        {
                            methodHead.Append(", ");
                            methodSignature.Append(", ");
                            methodBody.Append(", ");
                        }

                        methodHead.Append("float " + param.Name);
                        methodSignature.Append("float");
                        methodBody.Append(param.Name);
                    }

                    first = false;
                }

                methodHead.Append(")");
                methodSignature.Append(")");
                methodBody.Append(");");
                var signature = methodSignature.ToString();

                if (!UsedSignatures.Contains(signature))
                {
                    code.AppendLine("    " + methodHead.ToString());
                    code.AppendLine("    " + "{");
                    code.AppendLine("    " + methodBody.ToString());
                    code.AppendLine("    " + "}");
                    code.AppendLine("");
                    UsedSignatures.Add(signature);
                }

            }

            code.AppendLine("}");
            code.AppendLine("}");

            File.WriteAllText("MathF.cs", code.ToString());

        }
    }
}

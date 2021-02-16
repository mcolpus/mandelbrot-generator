using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;



namespace FractalApp
{
    public delegate Complex MethodDelegate(Complex z, Complex zn1, Complex c);

    class DynamicLambda
    {
        public static object ExecuteLambdaExpression(string lambdaExpression)
        {
            string source =
            "namespace FractalApp" +
            "{" +
                "public class LambdaClass" +
                "{" +
                    "delegate Complex MethodDelegate(Complex z, Complex zn1, Complex c);" +
                    "public static Complex LambdaMethod(Complex z, Complex zn1, Complex c)" +
                    "{" +
                        "return " + lambdaExpression + ";" +
                    "}" +
                "}" +
            "}";

            CompilerParameters parameters = new CompilerParameters();
            parameters.GenerateExecutable = false;
            parameters.GenerateInMemory = true;
            CSharpCodeProvider codeProvider = new CSharpCodeProvider();
            parameters.ReferencedAssemblies.Add(Assembly.GetEntryAssembly().Location);
            ICodeCompiler icc = codeProvider.CreateCompiler();
            CompilerResults results = icc.CompileAssemblyFromSource(parameters, source);

            Console.WriteLine("compiled with errors: " +
                results.Errors.HasErrors + ", warnings: " +
                results.Errors.HasWarnings);
            if(results.Errors.HasErrors)
            {
                foreach(CompilerError error in results.Errors)
                {
                    Console.WriteLine(error);
                }
            }
            

            if(!results.Errors.HasErrors && !results.Errors.HasWarnings)
            {
                Assembly ass = results.CompiledAssembly;

                object lambdaClassInstance =
                        ass.CreateInstance("FractalApp.LambdaClass");

                return lambdaClassInstance;
            }

            return null;
        }
    }
}

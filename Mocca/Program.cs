﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mocca.Compiler;

namespace Mocca {
    class Program {
        public static void Main(string[] args) {
            var parser = new MoccaParser("../../../Example/microbit.mocca", CompileMode.FILE_PASS);
			var tree = parser.Parse().Eval();
			var compiler = new PythonCompiler(tree);
			Console.WriteLine(compiler.Compile());
        }
    }
}
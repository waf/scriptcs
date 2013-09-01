using ScriptCs.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptCs.Engine.Clojure
{
    public class ClojureScriptEngine : IScriptEngine
    {
        public string BaseDirectory
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string FileName
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public ScriptResult Execute(string code, string[] scriptArgs, IEnumerable<string> references, 
            IEnumerable<string> namespaces, ScriptPackSession scriptPackSession)
        {
            throw new NotImplementedException();
        }
    }
}

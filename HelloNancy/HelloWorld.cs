using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;

namespace HelloNancy
{
    public class HelloWorld : NancyModule
    {
        public HelloWorld()
        {
            Get["/"] = _ => "Hello World, please work with tag added";
        }
    }
}
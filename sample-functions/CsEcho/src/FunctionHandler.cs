using System;
using System.Text;

namespace Function
{
    public class FunctionHandler
    {
        public void Handle(string input) {
            var queryString = Environment.GetEnvironmentVariable("Http_Query");
            var forwardHeader = Environment.GetEnvironmentVariable("Http_X_Forwarded_By");

            Console.WriteLine(
                string.Format("Request query string: '{0}' , forward header: '{1}'",
                queryString,
                forwardHeader));
        }
    }
}

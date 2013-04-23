using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text;
using System.Net;
using System.IO;

namespace Browser
{
    class UrlBrowser
    {
        public string requestHomepage(string url)
        {
            // used to build entire input
            StringBuilder sb = new StringBuilder();
            // used on each read operation
            byte[] buf = new byte[8192];
            // prepare the web page we will be asking for
            HttpWebRequest request = (HttpWebRequest)
                WebRequest.Create(url);
            // execute the request
            HttpWebResponse response = (HttpWebResponse)
            request.GetResponse();
            // we will read data via the response stream
            Stream resStream = response.GetResponseStream();
            string tempString = null;
            int count = 0;

            do
            {
                // fill the buffer with data
                count = resStream.Read(buf, 0, buf.Length);
                // make sure we read some data
                if (count != 0)
                {
                    // translate from bytes to ASCII text
                    tempString = Encoding.ASCII.GetString(buf, 0, count);
                    // continue building the string
                    sb.Append(tempString);
                }
            }
            while (count > 0); // any more data to read?
            // print out page source
            Console.WriteLine(sb.ToString());
            return sb.ToString();
        }
    }
}

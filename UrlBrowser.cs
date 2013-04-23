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
            try
            {
            StringBuilder sb = new StringBuilder();
            byte[] buf = new byte[8192];
            HttpWebRequest request = (HttpWebRequest)
                WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)
            request.GetResponse();
            Stream resStream = response.GetResponseStream();
            string tempString = null;
            int count = 0;

            do
            {
                count = resStream.Read(buf, 0, buf.Length);
                if (count != 0)
                {
                    tempString = Encoding.ASCII.GetString(buf, 0, count);
                    sb.Append(tempString);
                }
            }
            while (count > 0); // any more data to read?
            return sb.ToString();
            }
            catch(System.Net.WebException)
            {
                return "The remote name could not be resolved";
            }
            catch (System.UriFormatException)
            {
                return "Invalid URI: The format of the URI could not be determined";
            }
        }
    }
}

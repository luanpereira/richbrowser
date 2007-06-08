using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using JinwooMin.Logging;

namespace JinwooMin.Net
{
    /// <summary>
    /// TODO
    /// </summary>
    public class ConfluenceClient2
	{
        #region Constants
        
        private static string USER_AGENT = "Confluencer.NET/1.0 (+http://eclipseforum.net/)";

        #endregion

        #region Public methods

        /// <summary>
        /// TODO
        /// </summary>
        public static void DownloadFileWithLogin(ILogger logger, string urlLogin, string urlDownload, string filename, object progressBar)
        {
            // using cookie
            // ref: http://blog.strikefish.com/blog/index.cfm?mode=entry&entry=FE7C55D8-1422-201A-559B1E6213899E41
            CookieContainer cookieContainer = Login(logger, urlLogin); //new CookieContainer();

            //// login
            //HttpWebRequest reqLogin = (HttpWebRequest)WebRequest.Create(urlLogin);
            //// user-agent
            //// ref: http://www.primaryobjects.com/CMS/Article64.aspx
            //reqLogin.UserAgent = USER_AGENT;
            //reqLogin.AllowAutoRedirect = false;
            //HttpWebResponse resLogin = reqLogin.GetResponse() as HttpWebResponse;
            //StreamReader resReader = new StreamReader(resLogin.GetResponseStream());
            //string resStr = resReader.ReadToEnd();
            //logger.Debug(resStr);

            //// getcookies 에서 cookie 값을 가져오지 못한다.
            //// header안에 Set-Cookie 에 cookie가 있다.
            //foreach (string header in resLogin.Headers)
            //{
            //    logger.Debug("header=" + header + ", value=" + resLogin.Headers[header]);
            //    if (header == "Set-Cookie")
            //    {
            //        cookieContainer.SetCookies(new Uri(urlLogin), resLogin.Headers[header]);
            //    }
            //}

            // download
            HttpWebRequest reqDown = (HttpWebRequest)WebRequest.Create(urlDownload);
            reqDown.UserAgent = USER_AGENT;
            reqDown.CookieContainer = cookieContainer;
            HttpWebResponse resDown = reqDown.GetResponse() as HttpWebResponse;
            if (resDown.ContentLength > 0)
            {
                BinaryReader reader = new BinaryReader(resDown.GetResponseStream(), Encoding.UTF8);
                FileStream fs = new FileStream(filename, FileMode.Create);
                int downSize = 0;
                while (true)
                {
                    Application.DoEvents();
                    byte[] readContents = reader.ReadBytes(2048); // (int)resDown.ContentLength);

                    downSize += readContents.Length;
                    SetProgressBarValue(progressBar, (int)((float)downSize / resDown.ContentLength * 100));
                    //int value = (int)((float)downSize / resDown.ContentLength * 100);
                    //if (progressBar is ProgressBar)
                    //{
                    //    (progressBar as ProgressBar).Value = value;
                    //}
                    //else if (progressBar is ToolStripProgressBar)
                    //{
                    //    (progressBar as ToolStripProgressBar).Value = value;
                    //}
                    if (readContents.Length == 0)
                    {
                        break;
                    }
                    fs.Write(readContents, 0, readContents.Length);
                }
                fs.Close();
                reader.Close();
            }
            resDown.Close();
        }

        /// <summary>
        /// TODO
        /// </summary>
        public static void UploadFile(ILogger logger, string urlLogin, string urlUpload, string filename, object progressBar)
        {
            // ref: http://episteme.arstechnica.com/eve/forums/a/tpc/f/6330927813/m/146000692831

            SetProgressBarValue(progressBar, 0);

            CookieContainer cookieContainer = Login(logger, urlLogin);

            // upload

            // header
            HttpWebRequest reqUp = (HttpWebRequest)WebRequest.Create(urlUpload);
            string boundary = "----------------------------" +
                DateTime.Now.Ticks.ToString("x");
            reqUp.ContentType = "multipart/form-data; boundary=" + boundary;
            reqUp.Method = "POST";
            reqUp.KeepAlive = true;
            reqUp.UserAgent = USER_AGENT;
            reqUp.CookieContainer = cookieContainer;

            // body
            ASCIIEncoding encoding = new ASCIIEncoding();
            string comment = "Uploaded by Confluencer.NET";

            // make end of body
            StringBuilder sb = new StringBuilder();
            sb.Append("--" + boundary + "\r\n");
            sb.Append("Content-Disposition: form-data; name=\"confirm\"" + "\r\n");
            sb.Append("\r\n");
            sb.Append("Attach File(s)" + "\r\n");
            sb.Append("--" + boundary + "--");
            sb.Append("\r\n");
            byte[] bufferEndOfBody = encoding.GetBytes(sb.ToString());

            // set content length
            // 이게 젤 중요하다!!!!
            long contentSize = GetContentSize(boundary, filename, comment) + bufferEndOfBody.Length;
            reqUp.ContentLength = contentSize;
            Stream reqStream = reqUp.GetRequestStream();

            // write files
            TransferFile(boundary, filename, comment, reqStream, contentSize, progressBar);

            // write end of body
            reqStream.Write(bufferEndOfBody, 0, bufferEndOfBody.Length);

            // close request
            reqStream.Flush();
            reqStream.Close();

            // get response
            HttpWebResponse res = reqUp.GetResponse() as HttpWebResponse;
            Stream resStream = res.GetResponseStream();
            StreamReader sr = new StreamReader(resStream);

            //logger.Debug(sr.ReadToEnd());

            // close response
            sr.Close();
            resStream.Close();

            SetProgressBarValue(progressBar, 100);
        }

        #endregion

        #region Private methods
        
        private static CookieContainer Login(ILogger logger, string urlLogin)
        {
            // using cookie
            // ref: http://blog.strikefish.com/blog/index.cfm?mode=entry&entry=FE7C55D8-1422-201A-559B1E6213899E41
            CookieContainer cookieContainer = new CookieContainer();

            // login
            HttpWebRequest reqLogin = (HttpWebRequest)WebRequest.Create(urlLogin);
            // user-agent
            // ref: http://www.primaryobjects.com/CMS/Article64.aspx
            reqLogin.UserAgent = USER_AGENT;
            reqLogin.AllowAutoRedirect = false;
            HttpWebResponse resLogin = reqLogin.GetResponse() as HttpWebResponse;
            StreamReader resReader = new StreamReader(resLogin.GetResponseStream());
            string resStr = resReader.ReadToEnd();
            logger.Debug(resStr);

            // getcookies 에서 cookie 값을 가져오지 못한다.
            // header안에 Set-Cookie 에 cookie가 있다.
            foreach (string header in resLogin.Headers)
            {
                logger.Debug("header=" + header + ", value=" + resLogin.Headers[header]);
                if (header == "Set-Cookie")
                {
                    cookieContainer.SetCookies(new Uri(urlLogin), resLogin.Headers[header]);
                }
            }

            return cookieContainer;
        }

        private static void SetProgressBarValue(object progressBar, int value)
        {
            if (progressBar is ProgressBar)
            {
                (progressBar as ProgressBar).Value = value;
            }
            else if (progressBar is ToolStripProgressBar)
            {
                (progressBar as ToolStripProgressBar).Value = value;
            }
        }

        #region Upload
        
        private static string GetBuffer1String(string boundary, string filename)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("--" + boundary + "\r\n");
            sb.Append("Content-Disposition: form-data; name=\"file_0\"; filename=\"" + Path.GetFileName(filename) + "\"" + "\r\n");
            sb.Append("Content-Type: application/octet-stream" + "\r\n");
            sb.Append("\r\n");

            return sb.ToString();
        }

        private static string GetBuffer2String(string boundary, string comment)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\r\n");
            sb.Append("--" + boundary + "\r\n");
            sb.Append("Content-Disposition: form-data; name=\"comment_0\"" + "\r\n");
            sb.Append("\r\n");
            sb.Append(comment + "\r\n");
            sb.Append("--" + boundary + "\r\n");
            sb.Append("Content-Disposition: form-data; name=\"file_1\"; filename=\"\"" + "\r\n");
            sb.Append("Content-Type: application/octet-stream" + "\r\n");
            sb.Append("\r\n");
            sb.Append("\r\n");
            sb.Append("--" + boundary + "\r\n");
            sb.Append("Content-Disposition: form-data; name=\"comment_1\"" + "\r\n");
            sb.Append("\r\n");
            sb.Append("\r\n");
            sb.Append("--" + boundary + "\r\n");
            sb.Append("Content-Disposition: form-data; name=\"file_2\"; filename=\"\"" + "\r\n");
            sb.Append("Content-Type: application/octet-stream" + "\r\n");
            sb.Append("\r\n");
            sb.Append("\r\n");
            sb.Append("--" + boundary + "\r\n");
            sb.Append("Content-Disposition: form-data; name=\"comment_2\"" + "\r\n");
            sb.Append("\r\n");
            sb.Append("\r\n");
            sb.Append("--" + boundary + "\r\n");
            sb.Append("Content-Disposition: form-data; name=\"file_3\"; filename=\"\"" + "\r\n");
            sb.Append("Content-Type: application/octet-stream" + "\r\n");
            sb.Append("\r\n");
            sb.Append("\r\n");
            sb.Append("--" + boundary + "\r\n");
            sb.Append("Content-Disposition: form-data; name=\"comment_3\"" + "\r\n");
            sb.Append("\r\n");
            sb.Append("\r\n");
            sb.Append("--" + boundary + "\r\n");
            sb.Append("Content-Disposition: form-data; name=\"file_4\"; filename=\"\"" + "\r\n");
            sb.Append("Content-Type: application/octet-stream" + "\r\n");
            sb.Append("\r\n");
            sb.Append("\r\n");
            sb.Append("--" + boundary + "\r\n");
            sb.Append("Content-Disposition: form-data; name=\"comment_4\"" + "\r\n");
            sb.Append("\r\n");
            sb.Append("\r\n");

            return sb.ToString();
        }

        private static long GetContentSize(string boundary, string filename, string comment)
        {
            long size = 0;
            ASCIIEncoding encoding = new ASCIIEncoding();

            size += encoding.GetBytes(GetBuffer1String(boundary, filename)).Length;

            FileInfo fileInfo = new FileInfo(filename);
            size += fileInfo.Length;

            size += encoding.GetBytes(GetBuffer2String(boundary, comment)).Length;

            return size;
        }

        private static void TransferFile(string boundary, string filename, string comment, Stream stream, long totalLength, object progressBar)
        {
            long size = 0;
            ASCIIEncoding encoding = new ASCIIEncoding();

            byte[] buffer1 = encoding.GetBytes(GetBuffer1String(boundary, filename));
            stream.Write(buffer1, 0, buffer1.Length);

            size += buffer1.Length;
            SetProgressBarValue(progressBar, (int)((float)size / totalLength * 100)); 

            FileStream fs = new FileStream(filename, FileMode.Open);
            byte[] buffer = new Byte[checked((uint)Math.Min(4096, (int)fs.Length))];
            int bytesRead = 0;
            while ((bytesRead = fs.Read(buffer, 0, buffer.Length)) != 0)
            {
                Application.DoEvents();
                stream.Write(buffer, 0, bytesRead);
                size += bytesRead;
                SetProgressBarValue(progressBar, (int)((float)size / totalLength * 100));
            }
            fs.Close();

            byte[] buffer2 = encoding.GetBytes(GetBuffer2String(boundary, comment));
            stream.Write(buffer2, 0, buffer2.Length);

            size += buffer2.Length;
            SetProgressBarValue(progressBar, (int)((float)size / totalLength * 100));
        }

        #endregion

        #endregion
    }
}

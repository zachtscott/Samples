using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;

namespace Assignment7DataAccessClassLibrary
{
    public class VendorDA
    {

        public string GetVendorsFromJsonAPI(string url)
        {

            try
            {

                var webCl = new WebClient();
               string rawJson = webCl.DownloadString(url);
                if (rawJson != null)
                {
                    return rawJson;
                }

                else
                {
                    return null;
                }

            }

            catch (WebException webExcept)
            {
                string message = string.Empty;
                string status = (webExcept.Response as HttpWebResponse)?.StatusCode.ToString() ?? webExcept.Status.ToString();
                switch (status)
                {
                    case "NotFound":
                        message = "Problem with Entered URL. Please check Resource Name in URL";
                        break;
                    case "NameResolutionFailure":
                        message = "Server website name is incorrect. Please check website name in URL";
                        break;
                    case "UnknownError":
                        {
                            message = "Missing HTTP or HTTPS protocol in your URL. Please correct URL.";
                            break;
                        }

                    case "ConnectFailure":
                        {
                            message = "Unable to connect to server check your internet connection or server may be down";
                            break;
                        }
                }

                throw new WebException(message + "\n\n" + webExcept.Message.ToUpper());
            }

            catch (JsonException jsExcept)
            {
                throw jsExcept;
            }

            catch (Exception except)
            {
                throw except;
            }

            finally
            {

            }
            
        }

     public VendorDA() { }
    }
}

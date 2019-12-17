using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment7DataAccessClassLibrary;
using Newtonsoft.Json;
using System.Collections;

namespace Assignment7BusinessClassLibrary
{
    public class VendorBL
    {
        VendorDA vendorDataAccess = new VendorDA();
        Vendors vend = new Vendors();
        

        public List<Vendors> GetVendors()
        {
            try
            {
                string url = "https://cisweb.mccoy.txstate.edu:4443/api/vendors";
                string jsonData = vendorDataAccess.GetVendorsFromJsonAPI(url);

                if (jsonData != null)
                {
                    List<Vendors> listOfVendors = new List<Vendors>();

                    listOfVendors = JsonConvert.DeserializeObject<List<Vendors>>(jsonData);






                    return listOfVendors;
                }

                else
                {
                    return null;
                }
            }
            catch (JsonException jsExcept)
            {
                throw jsExcept;
            }
            catch(Exception except)
            {
                throw except;
            }
            finally
            {

            }
        }
        public VendorBL() { }
    }
}

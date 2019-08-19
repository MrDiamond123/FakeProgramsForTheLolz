using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeInstaller
{
    class Licence
    {
        string licenceKey;
        string ID;
        string PIN;

        int iID;
        int iPIN;

        public Licence(string licenceKey, string ID, string PIN)
        {
            this.licenceKey = licenceKey;
            this.ID = ID;
            this.PIN = PIN;
        }

        public bool CheckLicenceValid()
        {
            int iPIN;
            bool successPIN = int.TryParse(PIN, out iPIN);
            if (successPIN)
            {
                int iID;
                bool successID = int.TryParse(ID, out iID);

                
                if (successID)
                {
                    int iLicenceKey;
                    bool successLicenceKey = int.TryParse(licenceKey, System.Globalization.NumberStyles.HexNumber, System.Globalization.CultureInfo.InvariantCulture, out iLicenceKey);
                    var randomKeyVerify = new Random(iPIN);

                    for (int rng = 0; rng <= iID; rng++) {

                        int potato = randomKeyVerify.Next(999999);

                        if (rng == iID)
                        {
                            if (potato == iLicenceKey)
                            {
                                return true;
                            }
                            else { return false; };

                        } 

                        }
                        return false;
                }
                else { return false; }
            }
            else {
                return false;
            };
        }
        
    }
}

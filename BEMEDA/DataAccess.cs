using System;
using System.Collections.Generic;

using System.Text;
using System.Data.OleDb;
using BEME.Core;

namespace BEME.DA
{
    public abstract class DataAccessBase
    {
        private OleDbConnection bEMEConnectionObj;
        protected OleDbConnection BEMEConnectionObj
        {
            get
            {
                if (bEMEConnectionObj == null)
                {
                    bEMEConnectionObj = new OleDbConnection(Parameters.ConnectionStrings.BEMEStrConn);
                }
                return bEMEConnectionObj;
            }
        }
    }
}

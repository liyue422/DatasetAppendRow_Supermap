using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.Text;
using SuperMap.Desktop ;
using SuperMap.Data;
using SuperMap.Mapping;


namespace SuperMap.Desktop.DatasetAppendRow
{
    class _CtrlActionDatasetAppendRow:CtrlAction 
    {  
        public _CtrlActionDatasetAppendRow(IBaseItem caller)
            :base (caller)
        {
        
        }
       
        public override void Run()
        {
            try
            {
                _frmDatasetAppendRow frmDatasetAppendRow = new _frmDatasetAppendRow();
                frmDatasetAppendRow.Show();
            }
            catch (System.Exception ex)
            {
                SuperMap.Desktop.Application.ActiveApplication.Output.Output(ex.StackTrace);
            }
        }

    }
}

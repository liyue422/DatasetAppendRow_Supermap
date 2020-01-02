using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SuperMap.Desktop;
using SuperMap.Mapping;
using SuperMap.Data;
using SuperMap.UI;

namespace SuperMap.Desktop.DatasetAppendRow
{
    public partial class _frmDatasetAppendRow : Form
    {

        public _frmDatasetAppendRow()
        {
            InitializeComponent();
        }

        // 初始化数据源组合框,将现有数据源添加到下拉框中
        private void InitCmbDS(ComboBox cmb)
        {
            try
            {
                //首先获取当前窗体的工作空间对象
                Workspace Wkspace = Application.ActiveApplication.Workspace;
                Datasources objDss = Wkspace.Datasources;
                int DsCount = objDss.Count;

                if (DsCount == 0)
                {
                    return;
                }
                else
                {//添加数据源

                    cmb.Items.Clear();
                    cmb.BeginUpdate();
                    for (int i = 0; i < DsCount; i++)
                    {
                        //定义数据源对象
                        cmb.Items.Add(objDss[i].Alias);
                    }
                    cmb.EndUpdate();
                  //  cmb.SelectedIndex = 0;
                }
            }
            catch (System.Exception ex)
            {
                Application.ActiveApplication.Output.Output(ex.StackTrace);
            } 
        }


        //初始化数据集组合框，以便在combobox中选择指定数据源的点、线、面、属性表等矢量数据集
        private void InitCmbB(ComboBox DataSource, ComboBox DataSet)
        {
            try
            {
                //首先获取当前窗体的工作空间对象

                Workspace Wkspace = Application.ActiveApplication.Workspace;
                Datasources objDss = Wkspace.Datasources;

                int DtvCount = 0;
                //获取当前的数据源对象
                string DsName = DataSource.Text;
                if (DsName == "")
                {
                    return;
                }
                Datasource objDs = objDss[DsName];//
                if (objDs != null)
                {
                    //获取当前数据源中的数据集
                    Datasets objDts = objDs.Datasets;
                    int DtCount = objDts.Count;
                    if (DtCount == 0)
                    {
                        return;
                    }
                    else
                    {
                        //添加数据集

                        DataSet.Items.Clear();
                        DataSet.BeginUpdate();
                        for (int i = 0; i < DtCount; i++)
                        {
                            //定义数据源对象

                            Dataset objDt = objDts[i];
                            if (objDt.Type == DatasetType.Point || objDt.Type == DatasetType.Line || objDt.Type == DatasetType.Region ||
                                objDt.Type == DatasetType.CAD || objDt.Type == DatasetType.LineM ||objDt.Type == DatasetType.LinkTable || 
                                objDt.Type == DatasetType.Network || objDt.Type == DatasetType.Topology || objDt.Type == DatasetType.Model)
                            {
                                string DtName = objDt.Name;
                                DataSet.Items.Add(DtName);
                                DtvCount++;
                            }
                            else
                            {
                                continue;
                            }

                        }
                        DataSet.EndUpdate();
                    }
                }
                else
                {
                    DataSet.Items.Clear();
                }
            }
            catch (System.Exception ex)
            {
                Application.ActiveApplication.Output.Output(ex.StackTrace);
            }
        }


        // 初始化属性字段组合框,将指定数据集中的属性字段添加到下拉框中
        private void InitCmbF(ComboBox DataSource, ComboBox DataSet,ComboBox Field)
        {
            try
            {
                Workspace Wkspace = Application.ActiveApplication.Workspace;
                Datasources objDss = Wkspace.Datasources;

                DatasetVector datasetAdd = objDss[DataSource.Text].Datasets[DataSet.Text] as DatasetVector;

                Field.Items.Clear();
                Field.BeginUpdate();
                for (int i = 0; i < datasetAdd.FieldCount; i++)
                {
                    Field.Items.Add(datasetAdd.FieldInfos[i].Name);
                }
                Field.EndUpdate();
            }
            catch (System.Exception ex)
            {
                Application.ActiveApplication.Output.Output(ex.StackTrace);
            }
        
        }



        private void cmbDatasource_Click(object sender, EventArgs e)
        {
            //当数据源组合框下拉操作时，选择目标数据所在的数据源
            InitCmbDS(cmbDatasource);
        }

        private void cmbDataset_Click(object sender, EventArgs e)
        {
            //当数据源组合框下拉操作时，选择目标数据源下的数据集
            InitCmbB(cmbDatasource, cmbDataset);
        }

        private void cmbDatasourceAdd_Click(object sender, EventArgs e)
        {
            //当数据源组合框下拉操作时，选择要进行追加的数据集所在的数据源
            InitCmbDS(cmbDatasourceAdd);
        }

        private void cmbDatasetAdd_Click(object sender, EventArgs e)
        {
            //当数据源组合框下拉操作时，选择要进行追加的数据集
            InitCmbB(cmbDatasourceAdd, cmbDatasetAdd);          
        }

        private void cmbField_Click(object sender, EventArgs e)
        {
            //获取要进行追加的数据集包含的字段，选择相应的楼层字段（楼层字段为数字形式，如1/2/3等，“F1”等不可）
            InitCmbF(cmbDatasourceAdd, cmbDatasetAdd, cmbField);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Workspace Wkspace = Application.ActiveApplication.Workspace;
                Datasources objDss = Wkspace.Datasources;

                //待追加数据集/目标数据集
                DatasetVector datasetOut = objDss[cmbDatasource.Text].Datasets[cmbDataset.Text] as DatasetVector;
                
                //追加数据集
                DatasetVector datasetAdd = objDss[cmbDatasourceAdd.Text].Datasets[cmbDatasetAdd.Text] as DatasetVector;
                Recordset recordsetAdd = datasetAdd.GetRecordset(false, CursorType.Dynamic);

                //获取追加数据集中当前楼层
                int floorStart = Convert.ToInt32(recordsetAdd.GetFieldValue(cmbField.Text));
                //读取追加到的目标楼层号
                int floorEnd = Convert.ToInt32(textFloor.Text);

                if (floorStart < floorEnd)
                {
                    int floorCount = floorEnd - floorStart + 1;
                    int[] floorAdd = new int[floorCount];
                    for (int j = 0; j < floorCount; j++)
                    {
                        floorAdd[j] = floorStart + j; 
                    }

                    //修改楼层，并循环追加
                    for (int m = 0; m < floorCount; m++)
                    {
                        Recordset recordsetAdd1 = datasetAdd.GetRecordset(false, CursorType.Dynamic);
                        for(int n=0;n<recordsetAdd.RecordCount;n++)
                        {
                           
                            recordsetAdd1.Edit();
                            recordsetAdd1.SetFieldValue(cmbField.Text, floorAdd[m].ToString());
                            recordsetAdd1.Update();
                            recordsetAdd1.MoveNext();        

                        }

                        if(datasetOut.Append(recordsetAdd1))
                        {
                            Application.ActiveApplication.Output.Output("第" + floorAdd[m].ToString() + "层追加成功！");
                        }
                    }

                    MessageBox.Show("完成");
                    this.Close();

                }
                else
                {
                    MessageBox.Show("目标楼层输入错误！");                
                }
            }
            catch (System.Exception ex)
            {
                Application.ActiveApplication.Output.Output(ex.StackTrace);
            }

        } 
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

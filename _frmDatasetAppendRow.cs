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

        private void cmbDatasource_Click(object sender, EventArgs e)
        {
            //当数据源组合框下拉操作时，选择目标数据所在的数据源
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

                    cmbDatasource.Items.Clear();
                    cmbDatasource.BeginUpdate();
                    for (int i = 0; i < DsCount; i++)
                    {
                        //定义数据源对象
                        cmbDatasource.Items.Add(objDss[i].Alias);
                    }
                    cmbDatasource.EndUpdate();
                    cmbDatasource.SelectedIndex = 0;
                }
            }
            catch (System.Exception ex)
            {
                Application.ActiveApplication.Output.Output(ex.StackTrace);
            }
        }

        private void cmbDataset_Click(object sender, EventArgs e)
        {
            //当数据源组合框下拉操作时，选择目标数据源下的数据集
            try
            {
                //首先获取当前窗体的工作空间对象

                Workspace Wkspace = Application.ActiveApplication.Workspace;
                Datasources objDss = Wkspace.Datasources;

                int DtvCount = 0;
                //获取当前的数据源对象
                string DsName = cmbDatasource.Text;
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

                        cmbDataset.Items.Clear();
                        cmbDataset.BeginUpdate();
                        for (int i = 0; i < DtCount; i++)
                        {
                            //定义数据源对象

                            Dataset objDt = objDts[i];
                            if (objDt.Type == DatasetType.Point || objDt.Type == DatasetType.Line || objDt.Type == DatasetType.Region ||
                                objDt.Type == DatasetType.Tabular || objDt.Type == DatasetType.CAD || objDt.Type == DatasetType.LineM ||
                                objDt.Type == DatasetType.LinkTable || objDt.Type == DatasetType.Network || objDt.Type == DatasetType.Text ||
                                objDt.Type == DatasetType.Topology || objDt.Type == DatasetType.Model)
                            {
                                string DtName = objDt.Name;
                                cmbDataset.Items.Add(DtName);
                                DtvCount++;
                            }
                            else
                            {
                                continue;
                            }

                        }
                        cmbDataset.EndUpdate();
                    }
                }
                else
                {
                    cmbDataset.Items.Clear();
                }
            }
            catch (System.Exception ex)
            {
                Application.ActiveApplication.Output.Output(ex.StackTrace);
            }
        }

        private void cmbDatasourceAdd_Click(object sender, EventArgs e)
        {
            //当数据源组合框下拉操作时，选择要进行追加的数据集所在的数据源
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

                    cmbDatasourceAdd.Items.Clear();
                    cmbDatasourceAdd.BeginUpdate();
                    for (int i = 0; i < DsCount; i++)
                    {
                        //定义数据源对象
                        cmbDatasourceAdd.Items.Add(objDss[i].Alias);
                    }
                    cmbDatasourceAdd.EndUpdate();
                    cmbDatasourceAdd.SelectedIndex = 0;
                }
            }
            catch (System.Exception ex)
            {
                Application.ActiveApplication.Output.Output(ex.StackTrace);
            }

        }

        private void cmbDatasetAdd_Click(object sender, EventArgs e)
        {
            //当数据源组合框下拉操作时，选择要进行追加的数据集
            try
            {
                //首先获取当前窗体的工作空间对象

                Workspace Wkspace = Application.ActiveApplication.Workspace;
                Datasources objDss = Wkspace.Datasources;

                int DtvCount = 0;
                //获取当前的数据源对象
                string DsName = cmbDatasourceAdd.Text;
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

                        cmbDatasetAdd.Items.Clear();
                        cmbDatasetAdd.BeginUpdate();
                        for (int i = 0; i < DtCount; i++)
                        {
                            //定义数据源对象

                            Dataset objDt = objDts[i];
                            if (objDt.Type == DatasetType.Point || objDt.Type == DatasetType.Line || objDt.Type == DatasetType.Region ||
                                objDt.Type == DatasetType.Tabular || objDt.Type == DatasetType.CAD || objDt.Type == DatasetType.LineM ||
                                objDt.Type == DatasetType.LinkTable || objDt.Type == DatasetType.Network || objDt.Type == DatasetType.Text ||
                                objDt.Type == DatasetType.Topology || objDt.Type == DatasetType.Model)
                            {
                                string DtName = objDt.Name;
                                cmbDatasetAdd.Items.Add(DtName);
                                DtvCount++;
                            }
                            else
                            {
                                continue;
                            }

                        }
                        cmbDatasetAdd.EndUpdate();
                    }
                }
                else
                {
                    cmbDatasetAdd.Items.Clear();
                }
            }
            catch (System.Exception ex)
            {
                Application.ActiveApplication.Output.Output(ex.StackTrace);
            }
        }

        

        private void cmbField_Click(object sender, EventArgs e)
        {
            //获取要进行追加的数据集包含的字段，选择相应的楼层字段（楼层字段为数字形式，如1/2/3等，“F1”等不可）
            try
            {
                Workspace Wkspace = Application.ActiveApplication.Workspace;
                Datasources objDss = Wkspace.Datasources;

                DatasetVector datasetAdd = objDss[cmbDatasourceAdd.Text].Datasets[cmbDatasetAdd.Text] as DatasetVector;

                cmbField.Items.Clear();
                cmbField.BeginUpdate();
                for (int i = 0; i < datasetAdd.FieldCount; i++)
                {
                    cmbField.Items.Add(datasetAdd.FieldInfos[i].Name);
                }
                cmbField.EndUpdate();
            }
            catch (System.Exception ex)
            {
                Application.ActiveApplication.Output.Output(ex.StackTrace);
            }
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

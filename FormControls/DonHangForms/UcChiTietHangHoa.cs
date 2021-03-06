﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;

namespace QLDT.FormControls.DonHangForms
{
    public partial class UcChiTietHangHoa : BaseUserControl
    {
        private Action _callBack;
        private ChiTietDonHang _chiTiet;
        private BindingList<ChiTietHangHoa> _bindingList = new BindingList<ChiTietHangHoa>();

        public UcChiTietHangHoa(string tenHang, ChiTietDonHang chitiet, Action callBack)
        {
            InitializeComponent();

            Init(chitiet);

            txtTenHang.Text = tenHang;
            if (chitiet.ListChiTietHangHoa == null)
            {
                chitiet.ListChiTietHangHoa = new List<ChiTietHangHoa>();
            }

            _bindingList = new BindingList<ChiTietHangHoa>(chitiet.ListChiTietHangHoa);
            gridControlChiTiet.DataSource = _bindingList;
            _callBack = callBack;
            _chiTiet = chitiet;
            btnDeleteRow.ButtonClick += btnDeleteRow_ButtonClick;
            gridViewChiTiet.ActiveFilterString = string.Format("[IsActived] = '{0}'", true);

        }

        public override bool SaveData()
        {
            _chiTiet.ListChiTietHangHoa = _bindingList.ToList();
            _chiTiet.SoLuong = _bindingList.Count(s=>s.IsActived);
            _callBack();

            return true;
        }

        private void btnDeleteRow_ButtonClick(object sender, EventArgs e)
        {
            var index = gridViewChiTiet.GetFocusedDataSourceRowIndex();
            if (_bindingList.Count > 0)
            {
                var data = _bindingList[index];
                if (data.Id == 0)
                {
                    _bindingList.Remove(data);
                }
                else
                {
                    data.IsActived = false;
                }
            }
            gridControlChiTiet.Refresh();
        }

        private void gridViewChiTiet_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            GridView view = sender as GridView;
            if (view.FocusedColumn.FieldName == "IMEI")
            {
                //check duplicate code
                string currentCode = e.Value.ToString();
                for (int i = 0; i < view.DataRowCount; i++)
                {
                    if (i != view.GetDataSourceRowIndex(view.FocusedRowHandle))
                    {
                        if (view.GetRowCellValue(i, "IMEI").ToString() == currentCode)
                        {
                            e.ErrorText = "Trùng IMEI, IMEI này đã nhập rồi vui lòng kiểm tra lại!";
                            e.Valid = false;
                            break;
                        }
                    }
                }
            }
        }

        private void gridViewChiTiet_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            var data = gridViewChiTiet.GetRow(e.RowHandle) as ChiTietHangHoa;
            if (data != null) data.IsActived = true;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLDT.FormControls.KhoHangForms;

namespace QLDT.FormControls.ThuChiForms
{
    public partial class UcThuChiList : UserControl
    {
        private List<DanhMuc> _danhMucs = new List<DanhMuc>();
        private List<ThuChi> _thuChis = new List<ThuChi>();
        private long _selectedNoiDungId;

        public UcThuChiList()
        {
            InitializeComponent();
            InitAuthorize();
            ReloadData();
            ObserverControl.Regist(this.Name, "DefaultForm", Define.ActionTypeEnum.Close, RefreshData);
        }

        private void InitAuthorize()
        {
            if (!Authorization.IsHavePermission(Define.FeatureEnum.ThuChi.ToString(), Define.PermissionEnum.Write.ToString()))
            {
                btnAddLoaiThuChi.Visible = false;
                btnAddThuChi.Visible = false;
            }
        }

        private void RefreshData(object data)
        {
            if (data is DanhMuc)
            {
                FormBehavior.RefreshGrid(gridViewLoaiThuChi, (DanhMuc)data);
            }
            if (data is ThuChi)
            {
                FormBehavior.RefreshGrid(gridViewThuChi, (ThuChi)data);
            }
        }

        private void ReloadData()
        {
            ThreadHelper.LoadForm(() =>
            {
                CRUD.DisposeDb();

                _danhMucs = CRUD.DbContext.DanhMucs.Where(s => s.Loai == Define.LoaiDanhMucEnum.ThuChi.ToString() && s.IsActived).ToList();
                _danhMucs.Add(new DanhMuc() { Ten = "Tất cả" });
                _thuChis = CRUD.DbContext.ThuChis.ToList();

                gridControlLoaiThuChi.DataSource = _danhMucs;
                gridControlThuChi.DataSource = _thuChis;
            });
        }

        private void gridViewLoaiThuChi_Click(object sender, EventArgs e)
        {
            dynamic data = gridViewLoaiThuChi.GetRow(gridViewLoaiThuChi.FocusedRowHandle);
            if (data != null && data.Id != null)
            {
                _selectedNoiDungId = data.Id;
                if (data.Ten == "Tất cả")
                {
                    gridViewThuChi.ActiveFilterString = "";
                }
                else
                {
                    gridViewThuChi.ActiveFilterString = string.Format("[NoiDungId] = '{0}'", data.Id);
                }
            }
        }

        private void btnAddThuChi_Click(object sender, EventArgs e)
        {
            FormBehavior.GenerateForm(new UcThuChi(_selectedNoiDungId), "Thu Chi", this.ParentForm, this.Name);
        }

        private void btnAddLoaiThuChi_Click(object sender, EventArgs e)
        {
            FormBehavior.GenerateForm(new UcNhomHang(Define.LoaiDanhMucEnum.ThuChi), "Loại Thu Chi", this.ParentForm, this.Name);
        }

        private void gridViewLoaiThuChi_DoubleClick(object sender, EventArgs e)
        {
            ThreadHelper.LoadForm(() =>
            {
                dynamic data = gridViewLoaiThuChi.GetRow(gridViewLoaiThuChi.FocusedRowHandle);
                if (data != null && data.Id != null)
                {
                    var info = CRUD.DbContext.DanhMucs.Find(data.Id);
                    FormBehavior.GenerateForm(new UcNhomHang(Define.LoaiDanhMucEnum.ThuChi, info), "Loại Thu Chi", this.ParentForm, this.Name);
                }
            });
        }

        private void gridViewThuChi_DoubleClick(object sender, EventArgs e)
        {
            ThreadHelper.LoadForm(() =>
            {
                dynamic data = gridViewThuChi.GetRow(gridViewThuChi.FocusedRowHandle);
                if (data != null && data.Id != null)
                {
                    var info = CRUD.DbContext.ThuChis.Find(data.Id);
                    FormBehavior.GenerateForm(new UcThuChi(_selectedNoiDungId, info), "Thu Chi", this.ParentForm, this.Name);
                }
            });
        }




    }
}
